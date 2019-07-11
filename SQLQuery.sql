/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[user_id]
      ,[action]
      ,[login_date]
  FROM [EmmeSubic].[dbo].[Histories]