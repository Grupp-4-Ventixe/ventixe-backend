# Ventixe-backend

## Observera: 
Det här repot användes i början för hela gruppens lösningar, men på grund av merge-konflikter har vi beslutat att dela upp projektet i separata repositories – ett för varje microservice. Det här repot finns kvar som referens.

## Översikt
Detta är ett grupprojekt som utvecklar en eventhanteringssida där användare kan boka och hantera event. Projektet är uppdelat i flera microservices som var och en har ett tydligt ansvar.  

Projektet är byggt med ASP.NET Core, Entity Framework Core, och en separat frontend.

## Microservices

| Tjänst            | Beskrivning                                        |
|------------------|----------------------------------------------------|
| **AccountService** | Ansvarar för användarhantering (inloggning, registrering, mm) |
| **EventService**   | Hanterar event – skapa, uppdatera, ta bort event   |
| **BookingService** | Ansvarar för bokningar av event                    |
| **InvoiceService** | Skapar och hanterar fakturor kopplade till bokningar |

---

## AccountService (Nino/Elias)

AccountService är ansvarig för att hantera användare i systemet. Det innefattar registrering, inloggning och hämtning av användardata.  


