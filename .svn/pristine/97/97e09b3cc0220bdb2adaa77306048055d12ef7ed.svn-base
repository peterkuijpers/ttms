-- departments
insert into [dbo].[Departments] (  [Description]) VALUES
(  'Admin Department' );
insert into [dbo].[Departments] (  [Description]) VALUES
(  'Finance Department' );
insert into [dbo].[Departments] (  [Description]) VALUES
(  'Production Department' );
insert into [dbo].[Departments] (  [Description]) VALUES
(  'Distribution Department' );

-- levels
insert into [dbo].[levels] ( [full_description],[short_description] ) values
( 'User' 'User' );
insert into [dbo].[levels] ( [full_description],[short_description] ) values
( 'Manager' 'Manager' );
insert into [dbo].[levels] ( [full_description],[short_description] ) values
( 'Quality Assurer' 'QA' );
insert into [dbo].[levels] ( [full_description],[short_description] ) values
( 'General Mngr' 'GM' );
insert into [dbo].[levels] ( [full_description],[short_description] ) values
( 'Administrator' 'Admin' );
--users
INSERT INTO [dbo].[Users]
([Firstname],[Surname],[level_id],[department_id],[email],[userid],[password],[is_admin],[is_active])  VALUES
('Peter', 'Kuijpers', 5, 1, 'kuijpers@home.com', 'pkuijp1', 'pkp123', 1, 1 );
INSERT INTO [dbo].[Users]
([Firstname],[Surname],[level_id],[department_id],[email],[userid],[password],[is_admin],[is_active])  VALUES
('Test', 'Driver', 1, 1, 'tdriver@home.com', 'tdriver1', 'tdr123', 1, 1 );
INSERT INTO [dbo].[Users]
([Firstname],[Surname],[level_id],[department_id],[email],[userid],[password],[is_admin],[is_active])  VALUES
('Tony', 'Abbot', 1, 3, 'abbot@home.com', 'tabbot1', 'ta123', 0, 1 );
INSERT INTO [dbo].[Users]
([Firstname],[Surname],[level_id],[department_id],[email],[userid],[password],[is_admin],[is_active])  VALUES
('George', 'Michael', 1, 4, 'george@home.com', 'gmicha1', 'gm123', 0, 1 );

-- NCR_Status
INSERT INTO [dbo].[NCR_Status] ([id],[short_description],[Code])  VALUES
( 0, 'New NCR', 0);
INSERT INTO [dbo].[NCR_Status] ([id],[short_description],[Code])  VALUES
( 1, 'NCR Submitted', 1);
INSERT INTO [dbo].[NCR_Status] ([id],[short_description],[Code])  VALUES
( 2, 'NCR Assigned', 2 );
-- ACTIONS belonging to STATUS
insert into [dbo].[Actions] (  [ncr_status_id], [description], [Code] ) VALUES
( 0, 'Submit to Assignee', 'SUBMIT' );
insert into [dbo].[Actions] (  [ncr_status_id], [description], [Code] ) VALUES
( 1, 'Accept assignee', 'ACCEPT' );
insert into [dbo].[Actions] (  [ncr_status_id], [description], [Code] ) VALUES
( 1, 'Reject', 'REJECT' );
