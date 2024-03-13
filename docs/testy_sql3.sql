SELECT TOP 10 dtr.KasaID                         as kasa_id,
              dtr.KartaID                        as karta_id,
              dtr.ID                             as rachunek_id,
              k.IdentyfikatorSystemowy           as numer,
              k.OkazicielImie                    as imie,
              k.OkazicielNazwisko                as nazwisko,
              k.OkazicielIdentyfikator           as identyfikator,
              k.OkazicielWyroznik                as wyroznik,
              k.Opis                             as opis,
              k.FlgBlokada                       as blokada,
              t.WartoscBrutto                    as total,
              CAST(t.WartoscBrutto * 100 as INT) as total_cents,
              dtr.Numer                          as rachunek_numer,

              dtr.*,
              t.*
FROM NgastroDTRachunek dtr
         LEFT JOIN NgastroKarta k ON dtr.KartaID = k.ID
         LEFT JOIN NGastroDTRachunekTotalizer t ON t.DTRachunekID = dtr.ID
WHERE dtr.Status = 0
  --AND RodzajOtwarciaRachunkuID = '17242DE3-B2EB-47E4-B361-B302E5F35BAE' -- na kartê
  AND KasaID = 'E273EB11-AFF2-45E9-AA55-78AE8D2F0F3C'
ORDER BY dtr.DataOtwarcia DESC

SELECT * FROM NGastroDTRachunek order by DataOtwarcia desc