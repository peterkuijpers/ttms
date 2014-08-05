USE [TTMS]
GO

-- departments
INSERT INTO [dbo].[Departments] ([Description])
VALUES('Administration')
GO

--levels
INSERT INTO [dbo].[Levels] ([full_description],[short_description]) VALUES('User', 'User')
INSERT INTO [dbo].[Levels] ([full_description],[short_description]) VALUES('Manager', 'Manager')
INSERT INTO [dbo].[Levels] ([full_description],[short_description]) VALUES('Quality Assurance', 'QA')
INSERT INTO [dbo].[Levels] ([full_description],[short_description]) VALUES('General Manager', 'GM')
INSERT INTO [dbo].[Levels] ([full_description],[short_description]) VALUES('Administrator', 'Admin')
GO

-- status
INSERT INTO [dbo].[NCR_Status]([Code],[short_description])  VALUES( 1, 'New NCR waiting for Acceptance')
INSERT INTO [dbo].[NCR_Status]([Code],[short_description])  VALUES( 2, 'Some Status description' )
INSERT INTO [dbo].[NCR_Status]([Code],[short_description])  VALUES( 3, 'Create IA Plan and Submit' )
GO

INSERT INTO [dbo].[Users] ([Firstname],[Surname],[level_id],[department_id],[email],[userid],[password],[is_admin],[is_active])
VALUES( 'Peter', 'Kuijpers', 1, 1, 'kuijpers@optusnet.com.au', 'pkuijp1', 'pkp123', 1, 1 )
INSERT INTO [dbo].[Users] ([Firstname],[Surname],[level_id],[department_id],[email],[userid],[password],[is_admin],[is_active])
VALUES( 'Aaron', 'Surname', 1, 1, 'aaron@surname.com', 'aaron1', 'aaron123', 0, 1 )


GO
