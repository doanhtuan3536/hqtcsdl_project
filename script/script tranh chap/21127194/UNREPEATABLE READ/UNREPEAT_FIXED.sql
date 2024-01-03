﻿USE QLNHAKHOA
GO
CREATE OR ALTER PROC Sp_NV_LAYTHONGTINTK @TENDANGNHAP VARCHAR(50), @MATKHAU VARCHAR(50)
AS
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
	BEGIN TRY
		DECLARE @MATK VARCHAR(10)
		SET @MATK = NULL
		SET @MATK = (SELECT T.MATK FROM TAIKHOAN T WHERE T.TENTK = @TENDANGNHAP
		AND T.MATKHAU = @MATKHAU)
		PRINT @MATK
		IF (@MATK IS NULL)
			BEGIN
			PRINT N'Tài Khoản Không Tồn Tại'
			ROLLBACK TRAN
			RETURN 1
			END
		WAITFOR DELAY '00:00:10'

		SELECT T.TENTK, T.MATKHAU, NV.TENNV, NV.LOAINV
		FROM NHANVIEN NV, TAIKHOAN T
		WHERE T.TENTK = @TENDANGNHAP
		AND T.MATKHAU = @MATKHAU
		AND T.MATK = @MATK
		AND T.MATK = NV.MATK_NV
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0
GO


CREATE OR ALTER PROC Sp_NV_XOATAIKHOAN @MATK VARCHAR(10), @MANV VARCHAR(10)
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT *
		FROM dbo.TAIKHOAN
		WHERE MATK = @MATK)
		BEGIN
			PRINT CAST (@MATK AS VARCHAR(15)) + N' Không Tồn Tại'
			ROLLBACK TRAN
			RETURN 1
		END
		DELETE FROM TAIKHOAN
		WHERE MATK = @MATK
		--DELETE FROM NHANVIEN
		--WHERE MANV = @MANV
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 1
	END CATCH
COMMIT TRAN
RETURN 0

--DROP PROC dbo.Sp_NV_LAYTHONGTINTK
--DROP PROC dbo.Sp_NV_XOATAIKHOAN