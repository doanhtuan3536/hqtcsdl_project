﻿USE QLNHAKHOA
GO

CREATE PROC sp_NS_themthuoc
@MATHUOC VARCHAR(10),
@SOLUONG INT,
@MAHS VARCHAR(10)
AS
BEGIN TRAN
	IF NOT EXISTS (SELECT IDHOSOBA FROM HOSOBENHAN WHERE @MAHS = IDHOSOBA)
	BEGIN
		PRINT 'HO SO KHONG TON TAI'
		ROLLBACK TRAN
		RETURN 1
	END

	IF NOT EXISTS (SELECT MATHUOC FROM THUOC WHERE @MATHUOC = MATHUOC)
	BEGIN 
		PRINT 'MA THUOC KHONG TON TAI'
		ROLLBACK TRAN
		RETURN 1
	END

	IF @SOLUONG <= 0
	BEGIN
		PRINT 'SO LUONG KHONG DUOC <= 0'
		ROLLBACK  TRAN
		RETURN 1
	END

	IF (SELECT SLTON - @SOLUONG FROM THUOC WHERE MATHUOC = @MATHUOC) < 0
	BEGIN
		PRINT 'VUOT QUA SO LUONG TON'
		ROLLBACK TRAN
		RETURN 1
	END

	
	
	DECLARE @SLTON INT
	SET @SLTON = (
		SELECT SLTON
		FROM THUOC WITH (XLOCK)
		WHERE @MATHUOC = MATHUOC
	)
	WAITFOR DELAY '00:00:10'
	

	UPDATE THUOC
	SET SLTON = @SLTON - @SOLUONG
	WHERE MATHUOC = @MATHUOC
	INSERT INTO CT_THUOC VALUES(@MATHUOC, @MAHS, @SOLUONG)

COMMIT
GO


CREATE PROC sp_QTV_capnhatsl
@MATHUOC VARCHAR(10),
@SOLUONG INT
AS
BEGIN TRAN
	IF NOT EXISTS (SELECT MATHUOC FROM THUOC WHERE @MATHUOC = MATHUOC)
	BEGIN 
		PRINT 'MA THUOC KHONG TON TAI'
		ROLLBACK TRAN
	END

	IF @SOLUONG <= 0
	BEGIN
		PRINT 'SO LUONG KHONG DUOC <= 0'
		ROLLBACK  TRAN
	END
	
	UPDATE THUOC
	SET SLTON  = @SOLUONG
	WHERE MATHUOC = @MATHUOC
COMMIT
GO

--DROP PROC sp_NS_themthuoc