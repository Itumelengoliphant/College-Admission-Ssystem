CREATE PROCEDURE sp_InsertCourse
(
  @courseName VARCHAR(50),
  @courseCode VARCHAR(50),
  @courseType VARCHAR(50)	
)

AS
   BEGIN
   INSERT INTO [dbo].[tblCourse]
   (
     [courseName],
	 [courseCode],
	 [courseType])
   
   VALUES(
		 @courseName,
		 @courseCode,
		 @courseType
		 )

		 END