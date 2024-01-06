

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
CREATE ROLE NHASIROLE;
go

grant select, update on KHACHHANG to NHASIROLE
grant select on LICHNHASI to NHASIROLE
grant select on NHASI to NHASIROLE
grant select, insert on LICHHEN to NHASIROLE
grant select on HOSOBENHAN to NHASIROLE
grant select on THUOC to NHASIROLE
grant select on CT_THUOC to NHASIROLE
grant select on DICHVU to NHASIROLE
grant select on CT_DICHVU to NHASIROLE
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