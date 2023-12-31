﻿USE QLNHAKHOA
GO
CREATE PROC Sp_DangNhap
	@SDT VARCHAR(50),
	@MatKhau VARCHAR(50),
	@LoaiAcc INT OUTPUT,
	@Ma VARCHAR(10) OUTPUT,
	@MaTK VARCHAR(10) OUTPUT,
	@Trangthai BIT OUTPUT
AS
BEGIN TRAN
	BEGIN TRY
		SET @LoaiAcc = NULL
		SET @Ma = NULL

		IF EXISTS (
			SELECT LoaiAcc, MAKH
			FROM TAIKHOAN tk 
			JOIN KHACHHANG kh ON tk.MATK = kh.MATK_KH
			WHERE tk.TENTK = @SDT AND tk.MATKHAU = @MatKhau
		)
		BEGIN
			WAITFOR DELAY '00:00:10'
			SELECT @LoaiAcc = 0, @Ma = kh.MAKH, @MaTK = tk.MATK, @Trangthai = tk.TRANGTHAI
			FROM TAIKHOAN tk
			JOIN KHACHHANG kh ON tk.MATK = kh.MATK_KH
			WHERE tk.TENTK = @SDT AND tk.MATKHAU = @MatKhau
			COMMIT TRAN
			RETURN 1
		END
		ELSE IF EXISTS(SELECT LoaiAcc, MANHASI
			FROM TAIKHOAN tk
			JOIN NHASI ns ON tk.MATK = ns.MATK_NS
			WHERE tk.TENTK = @SDT AND tk.MATKHAU = @MatKhau)
		BEGIN
			SELECT @LoaiAcc = 2, @Ma = ns.MANHASI, @MaTK = tk.MATK, @Trangthai = tk.TRANGTHAI
			FROM TAIKHOAN tk
			JOIN NHASI ns ON tk.MATK = ns.MATK_NS
			WHERE tk.TENTK = @SDT AND tk.MATKHAU = @MatKhau
			COMMIT TRAN
			RETURN 1
		END
		ELSE
		BEGIN
			ROLLBACK TRAN
			RETURN 0
		END
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1

--drop proc Sp_DangNhap
--DROP PROC dbo.Sp_XOATAIKHOANKH
go
CREATE PROC Sp_XOATAIKHOANKH @MATK VARCHAR(10)
AS
BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT *
		FROM dbo.TAIKHOAN
		WHERE MATK = @MATK)
		BEGIN
			PRINT CAST (@MATK AS VARCHAR(15)) + N' Không Tồn Tại'
			ROLLBACK TRAN
			RETURN 0
		END
		DELETE FROM TAIKHOAN WHERE MATK = @MATK
		--DELETE FROM NHANVIEN WHERE MANV = @MANV
	END TRY
	BEGIN CATCH
		PRINT N'LỖI HỆ THỐNG'		ROLLBACK TRAN		RETURN 0
	END CATCH
COMMIT TRAN
RETURN 1