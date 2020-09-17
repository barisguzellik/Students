/*
 Navicat Premium Data Transfer

 Source Server         : BUTIKMEDYA
 Source Server Type    : SQL Server
 Source Server Version : 10504042
 Source Host           : 46.45.169.190:1433
 Source Catalog        : Students
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 10504042
 File Encoding         : 65001

 Date: 17/09/2020 19:27:41
*/


-- ----------------------------
-- Table structure for CLASS
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[CLASS]') AND type IN ('U'))
	DROP TABLE [dbo].[CLASS]
GO

CREATE TABLE [dbo].[CLASS] (
  [CLASSID] int  IDENTITY(1,1) NOT NULL,
  [CODE] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [NAME] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [SORT] int  NULL,
  [STATUS] int  NULL
)
GO

ALTER TABLE [dbo].[CLASS] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of CLASS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[CLASS] ON
GO

INSERT INTO [dbo].[CLASS] ([CLASSID], [CODE], [NAME], [SORT], [STATUS]) VALUES (N'1', N'1A', N'1/A', N'1', N'1')
GO

INSERT INTO [dbo].[CLASS] ([CLASSID], [CODE], [NAME], [SORT], [STATUS]) VALUES (N'2', N'2A', N'2/A', N'2', N'0')
GO

INSERT INTO [dbo].[CLASS] ([CLASSID], [CODE], [NAME], [SORT], [STATUS]) VALUES (N'3', N'3A', N'3/A', N'3', N'1')
GO

INSERT INTO [dbo].[CLASS] ([CLASSID], [CODE], [NAME], [SORT], [STATUS]) VALUES (N'5', N'4a', N'4/A', N'4', N'1')
GO

SET IDENTITY_INSERT [dbo].[CLASS] OFF
GO


-- ----------------------------
-- Table structure for LESSON
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LESSON]') AND type IN ('U'))
	DROP TABLE [dbo].[LESSON]
GO

CREATE TABLE [dbo].[LESSON] (
  [LESSONID] int  IDENTITY(1,1) NOT NULL,
  [CLASSID] int  NULL,
  [CODE] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [NAME] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [SORT] int  NULL,
  [STATUS] int  NULL
)
GO

ALTER TABLE [dbo].[LESSON] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of LESSON
-- ----------------------------
SET IDENTITY_INSERT [dbo].[LESSON] ON
GO

INSERT INTO [dbo].[LESSON] ([LESSONID], [CLASSID], [CODE], [NAME], [SORT], [STATUS]) VALUES (N'1', N'2', N'MAT', N'Matematik', N'1', N'1')
GO

SET IDENTITY_INSERT [dbo].[LESSON] OFF
GO


-- ----------------------------
-- Table structure for LOG
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[LOG]') AND type IN ('U'))
	DROP TABLE [dbo].[LOG]
GO

CREATE TABLE [dbo].[LOG] (
  [LOGID] int  IDENTITY(1,1) NOT NULL,
  [MANAGERID] int  NULL,
  [DATETIME] datetime2(0)  NULL,
  [HOSTNAME] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [HOSTADDRESS] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [MESSAGE] varchar(255) COLLATE Turkish_CI_AI  NULL
)
GO

ALTER TABLE [dbo].[LOG] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of LOG
-- ----------------------------
SET IDENTITY_INSERT [dbo].[LOG] ON
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'71', N'1', N'2020-09-17 19:11:28', N'http://localhost:5000/', N'::1', N'Giriş yapıldı.')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'72', N'1', N'2020-09-17 19:11:28', N'http://localhost:5000/dashboard', N'::1', N'Gösterge listelendi.')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'73', N'1', N'2020-09-17 19:11:35', N'http://localhost:5000/class', N'::1', N'Sınıflar listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'74', N'1', N'2020-09-17 19:11:39', N'http://localhost:5000/lesson', N'::1', N'Dersler listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'75', N'1', N'2020-09-17 19:11:41', N'http://localhost:5000/student', N'::1', N'Öğrenciler listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'76', N'1', N'2020-09-17 19:11:50', N'http://localhost:5000/student', N'::1', N'Öğrenciler listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'77', N'1', N'2020-09-17 19:11:51', N'http://localhost:5000/lesson', N'::1', N'Dersler listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'78', N'1', N'2020-09-17 19:11:53', N'http://localhost:5000/class', N'::1', N'Sınıflar listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'79', N'1', N'2020-09-17 19:12:01', N'http://localhost:5000/lesson', N'::1', N'Dersler listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'80', N'1', N'2020-09-17 19:12:07', N'http://localhost:5000/student', N'::1', N'Öğrenciler listelendi')
GO

INSERT INTO [dbo].[LOG] ([LOGID], [MANAGERID], [DATETIME], [HOSTNAME], [HOSTADDRESS], [MESSAGE]) VALUES (N'81', N'1', N'2020-09-17 19:12:14', N'http://localhost:5000/dashboard', N'::1', N'Gösterge listelendi.')
GO

SET IDENTITY_INSERT [dbo].[LOG] OFF
GO


-- ----------------------------
-- Table structure for MANAGER
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[MANAGER]') AND type IN ('U'))
	DROP TABLE [dbo].[MANAGER]
GO

CREATE TABLE [dbo].[MANAGER] (
  [MANAGERID] int  IDENTITY(1,1) NOT NULL,
  [USERNAME] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [PASSWORD] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [TOKEN] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [STATUS] int  NULL
)
GO

ALTER TABLE [dbo].[MANAGER] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of MANAGER
-- ----------------------------
SET IDENTITY_INSERT [dbo].[MANAGER] ON
GO

INSERT INTO [dbo].[MANAGER] ([MANAGERID], [USERNAME], [PASSWORD], [TOKEN], [STATUS]) VALUES (N'1', N'baris', N'e10adc3949ba59abbe56e057f20f883e', N'KRWWI1LMCNYQ7HP3WRYMOAXOIOC4UVPA', N'1')
GO

SET IDENTITY_INSERT [dbo].[MANAGER] OFF
GO


-- ----------------------------
-- Table structure for STUDENT
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[STUDENT]') AND type IN ('U'))
	DROP TABLE [dbo].[STUDENT]
GO

CREATE TABLE [dbo].[STUDENT] (
  [STUDENTID] int  IDENTITY(1,1) NOT NULL,
  [CLASSID] int  NULL,
  [IDENTITYNUMBER] bigint  NULL,
  [FIRSTNAME] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [LASTNAME] varchar(255) COLLATE Turkish_CI_AI  NULL,
  [NUMBER] int  NULL,
  [STATUS] int  NULL
)
GO

ALTER TABLE [dbo].[STUDENT] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of STUDENT
-- ----------------------------
SET IDENTITY_INSERT [dbo].[STUDENT] ON
GO

INSERT INTO [dbo].[STUDENT] ([STUDENTID], [CLASSID], [IDENTITYNUMBER], [FIRSTNAME], [LASTNAME], [NUMBER], [STATUS]) VALUES (N'1', N'1', N'8588488', N'Ali', N'Veli', N'0', N'0')
GO

SET IDENTITY_INSERT [dbo].[STUDENT] OFF
GO


-- ----------------------------
-- Auto increment value for CLASS
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[CLASS]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table CLASS
-- ----------------------------
ALTER TABLE [dbo].[CLASS] ADD CONSTRAINT [PK__CLASS__96D40B6CBECD961A] PRIMARY KEY CLUSTERED ([CLASSID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for LESSON
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[LESSON]', RESEED, 2)
GO


-- ----------------------------
-- Primary Key structure for table LESSON
-- ----------------------------
ALTER TABLE [dbo].[LESSON] ADD CONSTRAINT [PK__LESSON__9368334E7CD3B2CD] PRIMARY KEY CLUSTERED ([LESSONID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for LOG
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[LOG]', RESEED, 81)
GO


-- ----------------------------
-- Primary Key structure for table LOG
-- ----------------------------
ALTER TABLE [dbo].[LOG] ADD CONSTRAINT [PK__LOG__E39E279E205F3EFC] PRIMARY KEY CLUSTERED ([LOGID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for MANAGER
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[MANAGER]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table MANAGER
-- ----------------------------
ALTER TABLE [dbo].[MANAGER] ADD CONSTRAINT [PK__MANAGER__A76E78B1CB8BB6C0] PRIMARY KEY CLUSTERED ([MANAGERID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Auto increment value for STUDENT
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[STUDENT]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table STUDENT
-- ----------------------------
ALTER TABLE [dbo].[STUDENT] ADD CONSTRAINT [PK__STUDENT__495196F05DC5CAE9] PRIMARY KEY CLUSTERED ([STUDENTID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

