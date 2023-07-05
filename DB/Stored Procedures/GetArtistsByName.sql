CREATE PROCEDURE dbo.GetArtistsByName
	@artistName VARCHAR = ''
AS
BEGIN

	SELECT *
	FROM ARTIST
	WHERE
		title LIKE @artistName + '%'

END