--KHACH HANG
use master
go
exec sp_addlogin '985236147', 'xyz321', 'QLNHAKHOA';  
go
use QLNHAKHOA;
GO
CREATE USER [985236147] FOR LOGIN [985236147];
GO
EXEC sp_addrolemember 'KHACHHANGROLE', [985236147];
go



use QLNHAKHOA
go
CREATE ROLE KHACHHANGROLE;
go

grant select, update on KHACHHANG to KHACHHANGROLE
grant select on LICHNHASI to KHACHHANGROLE
grant select on NHASI to KHACHHANGROLE
grant select, insert on LICHHEN to KHACHHANGROLE
grant select on HOSOBENHAN to KHACHHANGROLE
grant select on THUOC to KHACHHANGROLE
grant select on CT_THUOC to KHACHHANGROLE
grant select on DICHVU to KHACHHANGROLE
grant select on CT_DICHVU to KHACHHANGROLE



--select * from taikhoan
--select * from khachhang
--select * from lichhen

CREATE PROC Sp_DangNhap
	@SDT VARCHAR(50),
	@MatKhau VARCHAR(50),
	@LoaiAcc INT OUTPUT,
	@Ma VARCHAR(10) OUTPUT,
	@MaTK VARCHAR(10) OUTPUT,
	@Trangthai BIT OUTPUT
AS
BEGIN
	SET @LoaiAcc = NULL
	SET @Ma = NULL

	IF EXISTS (
		SELECT LoaiAcc, MAKH
		FROM TAIKHOAN tk 
		JOIN KHACHHANG kh ON tk.MATK = kh.MATK_KH
		WHERE tk.TENTK = @SDT AND tk.MATKHAU = @MatKhau
	)
	BEGIN
		-- Retrieve account type and ID for customer
		SELECT @LoaiAcc = 0, @Ma = kh.MAKH, @MaTK = tk.MATK, @Trangthai = tk.TRANGTHAI
		FROM TAIKHOAN tk
		JOIN KHACHHANG kh ON tk.MATK = kh.MATK_KH
		WHERE tk.TENTK = @SDT AND tk.MATKHAU = @MatKhau
		RETURN 1
	END
	ELSE
	BEGIN
		RETURN 0
	END
END
go
DECLARE @LoaiAcc INT;
DECLARE @Ma VARCHAR(10);
DECLARE @MaTK VARCHAR(10);
DECLARE @Trangthai VARCHAR(10);
EXEC Sp_DangNhap '789456123', 'pass123', @LoaiAcc OUTPUT, @Ma OUTPUT, @MaTK OUTPUT, @Trangthai OUTPUT;
print(@Trangthai)
drop proc Sp_DangNhap