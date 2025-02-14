USE [DeveloperTest]
GO
/****** Object:  Table [dbo].[tbl_StudendInfo]    Script Date: 24-10-2024 14:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_StudendInfo](
	[StudendId] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [nvarchar](250) NULL,
	[Age] [int] NULL,
	[Image] [nvarchar](max) NULL,
	[Class] [nvarchar](50) NULL,
	[RollNo] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_StudendInfo] PRIMARY KEY CLUSTERED 
(
	[StudendId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Subjects]    Script Date: 24-10-2024 14:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Subjects](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[Language] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_SubjectTeachers]    Script Date: 24-10-2024 14:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SubjectTeachers](
	[SubjectTeacherId] [int] IDENTITY(1,1) NOT NULL,
	[SubjectId] [int] NULL,
	[TeacherId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectTeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Teachers]    Script Date: 24-10-2024 14:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Teachers](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Age] [int] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Gender] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_StudendInfo] ON 

INSERT [dbo].[tbl_StudendInfo] ([StudendId], [StudentName], [Age], [Image], [Class], [RollNo]) VALUES (1, N'om', 24, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'A', N'65')
INSERT [dbo].[tbl_StudendInfo] ([StudendId], [StudentName], [Age], [Image], [Class], [RollNo]) VALUES (2, N'rutwik', 25, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'B', N'23')
INSERT [dbo].[tbl_StudendInfo] ([StudendId], [StudentName], [Age], [Image], [Class], [RollNo]) VALUES (3, N'akshay', 26, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'C', N'18')
INSERT [dbo].[tbl_StudendInfo] ([StudendId], [StudentName], [Age], [Image], [Class], [RollNo]) VALUES (4, N'Pratik', 30, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'A', N'20')
INSERT [dbo].[tbl_StudendInfo] ([StudendId], [StudentName], [Age], [Image], [Class], [RollNo]) VALUES (6, N'aditya', 25, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'B', N'32')
INSERT [dbo].[tbl_StudendInfo] ([StudendId], [StudentName], [Age], [Image], [Class], [RollNo]) VALUES (9, N'Snehal', 25, N'~/Content/img/IMG_20240928_004605.jpg', N'B', N'12')
INSERT [dbo].[tbl_StudendInfo] ([StudendId], [StudentName], [Age], [Image], [Class], [RollNo]) VALUES (10, N'Tanu', 24, N'~/Content/img/IMG_20240928_004538.jpg', N'A', N'14')
SET IDENTITY_INSERT [dbo].[tbl_StudendInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Subjects] ON 

INSERT [dbo].[tbl_Subjects] ([SubjectId], [Name], [Class], [Language]) VALUES (1, N'Maths', N'A', N'English')
INSERT [dbo].[tbl_Subjects] ([SubjectId], [Name], [Class], [Language]) VALUES (2, N'English', N'B', N'English')
INSERT [dbo].[tbl_Subjects] ([SubjectId], [Name], [Class], [Language]) VALUES (3, N'Dot Net', N'C', N'English')
INSERT [dbo].[tbl_Subjects] ([SubjectId], [Name], [Class], [Language]) VALUES (4, N'MVC', N'B', N'English')
SET IDENTITY_INSERT [dbo].[tbl_Subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_SubjectTeachers] ON 

INSERT [dbo].[tbl_SubjectTeachers] ([SubjectTeacherId], [SubjectId], [TeacherId]) VALUES (2, 1, 1)
INSERT [dbo].[tbl_SubjectTeachers] ([SubjectTeacherId], [SubjectId], [TeacherId]) VALUES (5, 3, 3)
INSERT [dbo].[tbl_SubjectTeachers] ([SubjectTeacherId], [SubjectId], [TeacherId]) VALUES (6, 1, 3)
INSERT [dbo].[tbl_SubjectTeachers] ([SubjectTeacherId], [SubjectId], [TeacherId]) VALUES (7, 4, 1)
INSERT [dbo].[tbl_SubjectTeachers] ([SubjectTeacherId], [SubjectId], [TeacherId]) VALUES (8, 1, 4)
INSERT [dbo].[tbl_SubjectTeachers] ([SubjectTeacherId], [SubjectId], [TeacherId]) VALUES (9, 4, 3)
SET IDENTITY_INSERT [dbo].[tbl_SubjectTeachers] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Teachers] ON 

INSERT [dbo].[tbl_Teachers] ([TeacherId], [Name], [Age], [Image], [Gender]) VALUES (1, N'Jaydeep', 35, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'Male')
INSERT [dbo].[tbl_Teachers] ([TeacherId], [Name], [Age], [Image], [Gender]) VALUES (3, N'Shubham', 35, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'Male')
INSERT [dbo].[tbl_Teachers] ([TeacherId], [Name], [Age], [Image], [Gender]) VALUES (4, N'Aishwarya ', 30, N'~/Content/img/IMG_20240928_004538.jpg', N'Female')
INSERT [dbo].[tbl_Teachers] ([TeacherId], [Name], [Age], [Image], [Gender]) VALUES (6, N'Yash', 32, N'~/Content/img/Screenshot_2024-09-28-01-15-11-61_1c337646f29875672b5a61192b9010f9.jpg', N'Male')
SET IDENTITY_INSERT [dbo].[tbl_Teachers] OFF
GO
ALTER TABLE [dbo].[tbl_SubjectTeachers]  WITH CHECK ADD FOREIGN KEY([SubjectId])
REFERENCES [dbo].[tbl_Subjects] ([SubjectId])
GO
ALTER TABLE [dbo].[tbl_SubjectTeachers]  WITH CHECK ADD FOREIGN KEY([TeacherId])
REFERENCES [dbo].[tbl_Teachers] ([TeacherId])
GO
/****** Object:  StoredProcedure [dbo].[TestDb]    Script Date: 24-10-2024 14:22:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TestDb]
(
@Id int = null,
@name nvarchar(300)= null,
@age int=null,
@image nvarchar(max)=null,
@class nvarchar(50)=null,
@rollno nvarchar(50)=null,
@gender nvarchar(10)=null,
@lang nvarchar(50)=null,
@subid int=null,
@teachid int=null,

@Condition nvarchar(250)

)as
begin

if(@Condition='InsertStudentinfo')
begin
insert tbl_StudendInfo values (@name,@age,@image,@class,@rollno)
end

if(@Condition='FatchStudentInfo')
begin
select * from tbl_StudendInfo
end

if(@Condition='SearchStud')
begin
SELECT * FROM tbl_StudendInfo 
WHERE StudentName LIKE '%'+@name+'%'
end

if(@Condition='InsertTechinfo')
begin
insert tbl_Teachers values (@name,@age,@image,@gender)
end

if(@Condition='InsertSubinfo')
begin
insert tbl_Subjects values (@name,@class,@lang)
end

if(@Condition='TeacherName')
begin
select * from tbl_Teachers
end

if(@Condition='SubjectName')
begin
select * from tbl_Subjects
end

if(@Condition='InsertTeachSubject')
begin
insert tbl_SubjectTeachers values (@teachid,@subid)
end

if(@Condition='TeachSublst')
begin
SELECT s.Name AS SubjectName, t.Name AS TeacherName, s.Class
FROM tbl_Subjects s
INNER JOIN tbl_SubjectTeachers st ON s.SubjectId = st.SubjectId
INNER JOIN tbl_Teachers t ON st.TeacherId = t.TeacherId
end

end
GO
