# Software Requirements Analysis
## Airline Reservation System
## Ömer Talha BAYSAN

![image](https://user-images.githubusercontent.com/101717263/204128658-3d4fefb6-616f-4e07-a0c6-be5dd1460b5c.png)


## 20.07.2022 
## Airline Reservation System


# 1. Introduction

This Project is a desktop application where the airline reservation system is coded with
C# programming language. The application starts with a login form that leads to a login form.
The login form will be given an authentication mechanism, if the user id and password match
the condition, the user will login to the main form. The user can navigate to the Trains form
from the main form. Can add, edit, delete and view trains. User can manage different
Passengers, add, edit or update Passenger. The user can manage different Trips that allocate a
particular train to them. User can add, edit and delete Trips. The User can Book a Ticket for a
particular Trip. Finally, the user can cancel a reservation.

## 1.1. Purpose of the system
The airline reservation system includes details about flight schedules, passenger
reservations and ticket registrations.

## 1.2. Scope of the system
The users of the system consist of the system administrator and registrar. The
aircraft, passengers, travel and reservation information in the system are under the
control of the system users.

# 2. Current System
In several countries, if someone wants to book a flight ticket, they follow one of these
things: Elle goes to the airport and book the ticket. Downloading the ticket as a paper
document. Fill out the ticket from the System and print it out and deliver it to the airport.
Booking the ticket online at some registered ticket offices. Even the above approaches arebooking tickets online, not completely online. The traveler may not have much freedom over
this approach. Therefore, the Passenger may or may not be satisfied with this approach as it
involves manual intervention such as traveling to the airport to book their ticket.

# 3. Proposed System
The proposed system provides complete freedom for the user, where the user can log in
to this application and book her ticket on her own system.

## 3.1. Functional requirements

### 3.1.1. Flights
In the Flights module, we can enter flight code, date, number of seats, source
and destination information, as well as view registered flights. We can update and
delete saved flights on the flight logs view screen.

### 3.1.2. Passangers
To register a passenger in the Passengers module, we must enter the passenger
code, name, number, address, nation, telephone number and gender. We can update
or delete registered passengers from the passenger records display screen.

### 3.1.3. Tickets
In order to reserve a ticket in the ticket reservation module, we need to enter
the ticket and flight code, passenger code, name, nationality, passport number and
ticket price information.3.1.4. Cancellation
In the ticket cancellation module, we need to enter the cancellation, ticket and
flight code and date information for ticket cancellation.

## 3.2. Nonfunctional requirements

### 3.2.1.Usability
Airline Reservation System serves a variety of people, including those who are
not inclined to use computers. Therefore, My Wallet must be clear and easy to use.

### 3.2.2. Security
The system contains a lot of information such as flight, passenger and
reservation. The data is kept in a database. Database security protects data against
data theft.

### 3.2.3. Interface
The system offers multiple tools to the user. It is important that the interface
has been developed for the most efficient and easiest use of these tools for the user.

# 4. System models

## 4.1. Scenarios

![image](https://user-images.githubusercontent.com/101717263/204128670-7be35c15-61d2-4e0f-92c0-f5b6bf5c8156.png)

![image](https://user-images.githubusercontent.com/101717263/204128673-47560741-2ad6-4e80-a60c-5b87fe6e5781.png)

## 4.2. Use Case Model

- Admin Use Case Model\
![image](https://user-images.githubusercontent.com/101717263/204128682-9f742409-9352-4b26-91eb-215ca9b0b916.png)

- User Use Case Model\
![image](https://user-images.githubusercontent.com/101717263/204128703-9f3a9564-5249-4dc4-a293-8949a501ac23.png)

## 4.3. Screen Mock-ups
- Log-in\
![image](https://user-images.githubusercontent.com/101717263/204128706-fb6bb88b-4921-4d8f-b631-5c67f0a2f3a7.png)

- Home\
![image](https://user-images.githubusercontent.com/101717263/204128714-eaa819b5-b711-4107-94f8-6d24482fadb1.png)

- Flights\
![image](https://user-images.githubusercontent.com/101717263/204128770-ff7fc98e-af22-4280-9116-49d1c9c4adf7.png)

- View Schdule Flights\
![image](https://user-images.githubusercontent.com/101717263/204128779-0ef47edc-3be6-4d57-8a70-0ab13b97c3d7.png)

- Passengers\
![image](https://user-images.githubusercontent.com/101717263/204128762-4255386b-803c-40a5-aa4b-8d070017ac2b.png)

- View Passengers\
![image](https://user-images.githubusercontent.com/101717263/204128787-f90e57bb-420b-4ed6-9d59-4ee9c125af66.png)

- Tickets\
![image](https://user-images.githubusercontent.com/101717263/204128803-a5fde7a8-c912-470d-bbc4-07877bd6a62a.png)

- Cancellation\
![image](https://user-images.githubusercontent.com/101717263/204128810-5675f287-6eef-4d82-b344-57f05031cd04.png)

