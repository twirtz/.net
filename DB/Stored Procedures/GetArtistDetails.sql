CREATE PROCEDURE dbo.GetArtistDetails
	@artistID INT = 1
AS
BEGIN

	SELECT *
	FROM ARTIST ar
	LEFT JOIN Album al on ar.artistID = al.artistID
	LEFT JOIN Song s on ar.artistID = s.artistID AND s.albumID = al.albumID
	WHERE
		ar.artistID = @artistID

END