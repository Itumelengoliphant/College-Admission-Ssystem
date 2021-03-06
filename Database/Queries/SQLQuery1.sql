USE [CollegeAdmissionSystem]
GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_ApplicantInfo]    Script Date: 2019/08/21 18:05:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_Insert_ApplicantInfo]
(
   @name varchar(50)
  ,@lastName varchar(50)
  ,@identityNum varchar(13)
  ,@address varchar(50)
  ,@phone varchar(12)
  ,@email varchar(50)
  ,@school varchar(50)
  ,@applicationDate smalldatetime
  ,@gender varchar(20)
  ,@highestGrade varchar(20)
  ,@sub1 varchar(50)
  ,@sub2 varchar(50)
  ,@sub3 varchar(50)
  ,@sub4 varchar(50)
  ,@sub5 varchar(50)
  ,@sub6 varchar(50)
  ,@sub7 varchar(50)
  ,@appStatus varchar(20)
  ,@password varchar(50)
  ,@studNum varchar(10)
  ,@aps int
)

AS
   BEGIN
   INSERT INTO [dbo].[ApplicationInfotbl]
   ([name]
   ,[lastName]
   ,[identityNum]
   ,[address]
   ,[phone]
   ,[email]
   ,[school]
   ,[applicationDate]
   ,[gender]
   ,[highestGrade]
   ,[sub1]
   ,[sub2]
   ,[sub3]
   ,[sub4]
   ,[sub5]
   ,[sub6]
   ,[sub7]
   ,[appStatus]
   ,[password]
   ,[studNum]
   ,[aps])

   VALUES
   (
   @name
  ,@lastName
  ,@identityNum
  ,@address
  ,@phone
  ,@email
  ,@school
  ,@applicationDate
  ,@gender
  ,@highestGrade
  ,@sub1
  ,@sub2
  ,@sub3
  ,@sub4
  ,@sub5
  ,@sub6
  ,@sub7
  ,@appStatus
  ,@password
  ,@studNum
  ,@aps
   )

   END