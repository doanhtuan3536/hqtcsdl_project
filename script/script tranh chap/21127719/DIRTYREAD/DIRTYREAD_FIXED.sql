﻿USE QLNHAKHOA
GO

CREATE PROC sp_KH_xemhs
@MAKH VARCHAR(10)
AS
BEGIN TRAN
	--SET TRAN ISOLATION LEVEL READ UNCOMMITTED

	BEGIN TRY
	IF NOT EXISTS(SELECT MAKH FROM KHACHHANG WHERE MAKH = @MAKH)
	BEGIN
		PRINT 'MA KHACH HANG KHONG TON TAI'
		ROLLBACK TRAN
		RETURN 0
	END

	SELECT IDHOSOBA, NGAYKHAM, MANHASI, MAKH, MAHD
	FROM HOSOBENHAN
	WHERE @MAKH = MAKH
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 0	
	END CATCH
COMMIT TRAN
RETURN 1
GO


CREATE PROC sp_themhs
@MAHS VARCHAR(10),
@MAKH VARCHAR(10),
@MANHASI VARCHAR(10),
@NGAYKHAM DATETIME,
@HOTEN NVARCHAR(50),
@SDT VARCHAR(15)
AS
BEGIN TRAN
	BEGIN TRY
	IF NOT EXISTS(SELECT MAKH FROM KHACHHANG WHERE MAKH = @MAKH)
	BEGIN
		PRINT 'MA KHACH HANG KHONG TON TAI'
		ROLLBACK TRAN
	END

	INSERT INTO HOSOBENHAN VALUES(@MAHS, @NGAYKHAM, @MAKH, @MANHASI, NULL)
	--WAIT
	WAITFOR DELAY '0:0:10'

	
	IF CONVERT(DATE, @NGAYKHAM) != CONVERT(DATE, GETDATE())
	BEGIN
		PRINT 'NGAY KHAM KHONG PHU HOP'
		ROLLBACK TRAN
	END

	IF (SELECT HOTEN FROM KHACHHANG WHERE MAKH = @MAKH) != @HOTEN
		OR (SELECT SDT FROM KHACHHANG WHERE MAKH = @MAKH) != @SDT
	BEGIN
		PRINT N'THONG TIN KHACH HANG KHONG TRUNG KHOP VOI MA KHACH HANG'
		ROLLBACK TRAN
		RETURN 0
	END
	END TRY
	BEGIN CATCH
	PRINT N'LỖI HỆ THỐNG'
		ROLLBACK TRAN
		RETURN 0	
	END CATCH
COMMIT TRAN
RETURN 1
GO