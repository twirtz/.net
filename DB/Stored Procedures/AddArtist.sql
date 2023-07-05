CREATE PROCEDURE dbo.AddArtist
	@dateCreation SMALLDATETIME = NULL,
	@title VARCHAR(MAX) = '',
	@biography VARCHAR(MAX) = '',
	@imageURL VARCHAR(MAX) = '',
	@heroURL VARCHAR(MAX) = ''
AS
	SET @dateCreation = ISNULL(@dateCreation, GETDATE())
BEGIN
	INSERT INTO Artist VALUES(@dateCreation, @title, @biography, @imageURL, @heroURL)
END