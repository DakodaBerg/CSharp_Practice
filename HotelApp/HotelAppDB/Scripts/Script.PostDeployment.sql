/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (select 1 from dbo.RoomTypes)
begin
    insert into dbo.RoomTypes(Title,Description,Price)
    values ('King Size Bed', 'A Room King Size bed and a window.', 100),
    ('Two Queen Size Beds','A Room With Two queen-size beds and a window.', 115),
    ('Executive Suite','Two rooms, each with a king size bed and a window.', 205);
end

if not exists (select 1 from dbo.Rooms)
begin
    declare @RoomId1 int;
    declare @RoomId2 int;
    declare @RoomId3 int;

    select @RoomId1 = Id from dbo.RoomTypes where Title = 'King Size Bed';
    select @RoomId2 = Id from dbo.RoomTypes where Title = 'Two Queen Size Beds';
    select @RoomId3 = Id from dbo.RoomTypes where Title = 'Executive Suite';

    insert into dbo.Rooms (RoomNumber, RoomTypeId)
    values ('101', @RoomId1),
           ('102', @RoomId1),
           ('103', @RoomId1),
           ('201', @RoomId2),
           ('202', @RoomId2),
           ('301', @RoomId3);
end