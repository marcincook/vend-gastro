USE [BB_28_TOW_23]
GO

INSERT INTO [dbo].[NGastroDTRachunekPlatnosc]
           ([ID]
           ,[DTRachunekID]
           ,[FormaPlatnosciID]
           ,[Kwota]
           ,[FlgOplacona]
           ,[ZaokragleniePlatnosci])
     VALUES
           (NEWID()
           ,'1C8CDA7D-A534-4A60-9478-22962B6E1D8B'
           ,'F3041AD8-1B27-4F33-8F3D-DCA030D19F90' --- tu forma 
           ,2.00
           ,0
           ,0)
GO


