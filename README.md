# Degree-Issuance-System
A system where a student can submit an application to receive his or her degree.  The application is passed through a few checks and permissions, granted by the other departments. 

## Relationship Mapping
student-> fyp -> finance ->onestop -> director

That is the path the form will take inside the database. The student submits the form, which is then passed on to the fyp center. Here it is either accepted or rejected and in the case of acceptance, is passed on to the finance department. There, the student’s pending dues are checked, and according to that, another permission is granted. The onestop center generates a transcript for the student that contains their grades from over the course of the degree. Onestop processes the request and forwards it to the director, who gives it the final seal of approval. The director then updates the status of the request, which can go from “pending” to “accepted” or “rejected”. This information is displayed onto the student’s view of the database as well.

## Relational Database Schema
![relational schema drawio](https://user-images.githubusercontent.com/110716479/231242588-39881cee-acf4-41c9-8258-960a027077a3.png)


## ERD Diagram
![project erd drawio](https://user-images.githubusercontent.com/110716479/231242125-aba42472-a1d9-4571-933a-62c3070b8a23.png)
