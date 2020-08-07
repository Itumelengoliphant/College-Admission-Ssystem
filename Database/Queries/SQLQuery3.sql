CREATE TABLE [dbo].[ApplicationInfotbl](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[identityNum] [varchar](13) NOT NULL,
	[address] [varchar](50) NOT NULL,
	[phone] [varchar](12) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[school] [varchar](50) NOT NULL,
	[applicationDate] [smalldatetime] NOT NULL,
	[gender] [varchar](20) NOT NULL,
	[highestGrade] [varchar](20) NOT NULL,
	[sub1] [varchar](50) NOT NULL,
	[sub2] [varchar](50) NOT NULL,
	[sub3] [varchar](50) NOT NULL,
	[sub4] [varchar](50) NOT NULL,
	[sub5] [varchar](50) NOT NULL,
	[sub6] [varchar](50) NOT NULL,
	[sub7] [varchar](50) NOT NULL,
	[appStatus] [varchar](20) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[studNum] [varchar](10) NOT NULL,
	[aps] [int] NOT NULL,
	[role] [varchar](20) NOT NULL	
 CONSTRAINT [PK_ApplicationInfotbl] PRIMARY KEY CLUSTERED 
(
	[studNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


