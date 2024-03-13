SELECT
    st.Nazwa,
    sb.ObiektSymbol,
    t.WartoscBrutto,
    dtr.Numer,
    sb.ObiektID,
    s.StanowiskoID,
    *
    FROM NSysSesjaObiektBlokada sb
    LEFT JOIN NGastroDTRachunek dtr ON dtr.ID = sb.ObiektID
    LEFT JOIN NGastroDTRachunekTotalizer t ON t.DTRachunekID = dtr.ID
    LEFT JOIN NSysSesja s ON s.ID = sb.SesjaID
    LEFT JOIN NSysStanowisko st ON st.ID = s.StanowiskoID
    WHERE sb.ObiektSymbol = 'NGastroDTRachunek'
	AND dtr.KasaID = 'E273EB11-AFF2-45E9-AA55-78AE8D2F0F3C'


	-- getBasket 

SELECT
    st.Nazwa as pos, 
    CAST(t.WartoscBrutto * 100 as Integer) as cents,
	t.WartoscBrutto as total,
    dtr.Numer as nr,
    sb.ObiektID as rid 
FROM NSysSesjaObiektBlokada sb
    LEFT JOIN NGastroDTRachunek dtr ON dtr.ID = sb.ObiektID
    LEFT JOIN NGastroDTRachunekTotalizer t ON t.DTRachunekID = dtr.ID
    LEFT JOIN NSysSesja s ON s.ID = sb.SesjaID
    LEFT JOIN NSysStanowisko st ON st.ID = s.StanowiskoID
WHERE sb.ObiektSymbol = 'NGastroDTRachunek'
	AND dtr.KasaID = 'E273EB11-AFF2-45E9-AA55-78AE8D2F0F3C'

	SELECT * FROM NGastroDTRachunek WHERE ID = '02188AD4-412D-45F4-B9C4-A313B9E607C3'

	SELECT * FROM NGastroDTRachunekTotalizer WHERE DTRachunekID = '1C8CDA7D-A534-4A60-9478-22962B6E1D8B'

	SELECT * FROM NGastroDTRachunekPlatnosc WHERE DTRachunekID = '02188AD4-412D-45F4-B9C4-A313B9E607C3'

	SELECT * FROM NGastroFormaPlatnosci WHERE ID = '4217C262-56A9-4EC0-B747-476BEDB384C8' 
	-- dotacja 4217C262-56A9-4EC0-B747-476BEDB384C8
	-- goscie F3041AD8-1B27-4F33-8F3D-DCA030D19F90
	-- gotowka E85BDF97-C1AD-4E3C-AC20-3912885BDC00
	-- televend 1F7055E8-368C-4EE6-B106-61C2041FA237

	SELECT * FROM NGastroDotacjaKartaWykorzystanie 
	-- WHERE InfoRachunekPK = '1C8CDA7D-A534-4A60-9478-22962B6E1D8B'
	ORDER BY DataTransakcji DESC

	SELECT * FROM NGastroDTRachunek

	UPDATE NGastroDTRachunekPlatnosc SET FormaPlatnosciID = 'E85BDF97-C1AD-4E3C-AC20-3912885BDC00' WHERE ID = '750EA134-CAD4-4CED-90BB-811F91F55F7B'



		   SELECT * FROM NGastroRodzajOtwarciaRachunku

		   SELECT * FROM NgastroKarta where IdentyfikatorSystemowy = '3120379099' -- ''D0FAF4DD-5C1C-4340-B2CA-C9C686B78402 
		   
		   -- USTAWIAMY TYP NA KARTE 
		   UPDATE NGastroDTRachunek SET 
		   KartaID = 'D0FAF4DD-5C1C-4340-B2CA-C9C686B78402' ,
		   RodzajOtwarciaRachunkuID = '17242DE3-B2EB-47E4-B361-B302E5F35BAE'
		   WHERE ID = '4C0F0879-C681-4EA9-A8CE-7086D0906B66' -- tu rachunek id 

		   	 -- Insertujemy forme televend 
	INSERT INTO [dbo].[NGastroDTRachunekPlatnosc]
           ([ID]
           ,[DTRachunekID]
           ,[FormaPlatnosciID]
           ,[Kwota]
           ,[FlgOplacona]
           ,[ZaokragleniePlatnosci])
     VALUES
           (NEWID()
           ,'4C0F0879-C681-4EA9-A8CE-7086D0906B66' -- tu rachunek id 
           ,'1F7055E8-368C-4EE6-B106-61C2041FA237' --- tu forma 
           ,23.65
           ,0,0)