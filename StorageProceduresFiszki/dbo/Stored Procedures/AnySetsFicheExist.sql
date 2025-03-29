CREATE PROCEDURE [dbo].[AnySetsFicheExist]
	@UserId INT = NULL,
	@SetFicheId INT =NULL

AS
BEGIN
DECLARE @Exsist INT =0;
SELECT	TOP(1) @Exsist=1
FROM [SetsFiche] [s]
JOIN [Users] [u] ON [u].Id=[s].UserId
WHERE 
	([UserId] = @UserId OR @UserId IS NULL)  AND
	([s].[Id] = @SetFicheId OR @SetFicheId IS NULL )

SELECT @Exsist
END