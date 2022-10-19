# Http Methods

## Resource

An important thingy to the user of your API.


## The Core Methods

| Method | Resource Type | Meaning | Safe | Idempotent | Cacheable |
| -- | -- | -- | --- | -- | --- |
| GET | Collection (/developers) | Get this collection | True | True | True |
| GET | Document (/developers/:id) | Get this Document | True | True | True |
| Post | Collection (/developers) | Append this document to the collection | False | False | False* |
| Post | Document (rare) | Submit this for processing | False | False | False |
| Put | Collection (rare) | Replace this collection with this data | Fale | True | False |
| Put | Document (/on-call-developer) | Replace this resource | False | True | False |
| Delete | Collection (rare) | Remove this | False | True | False |
| Delete | Document | Remove This | False | True | False |


### Another "Resource Oriented" Thing Is SQL

| (SQL) DML |  (HTTP) Methods |
| --- | ----- |
| Select | GET | 
| Insert | POST | 
| Delete | Delete |
| Update | PUT (It's Not!) |