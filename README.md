# UPSTICKS DIRECTORY
## Training repository for .Net Core API & Entity Framework Core

### App purpose 
Create a digital directory to enable companies relating to the residential property sale and purchase process to list their company.

Allow these companies to upload multiple office addresses and contact details specific to these locations. 

### Current tables and fields used within the database

#### Estate Agent

 - companyId _PK
 - companyName NotNull
 - companyEmail NotNull
 - companyTelephone NotNull

#### Estate Agent Address
 - addressId _PK
 - addressLine1 NotNull
 - addressLine2
 - addressTown NotNull
 - addressCounty NotNull
 - addressPostcode NotNull
 - addressEmail NotNull
 - addressTelephone NotNull
 - companyId _FK NotNull
 
 #### Conveyancer

 - companyId _PK
 - companyName NotNull
 - companyEmail NotNull
 - companyTelephone NotNull

#### Conveyancer Address
 - addressId _PK
 - addressLine1 NotNull
 - addressLine2
 - addressTown NotNull
 - addressCounty NotNull
 - addressPostcode NotNull
 - addressEmail NotNull
 - addressTelephone NotNull
 - companyId _FK NotNull
 
  #### Removals

 - companyId _PK
 - companyName NotNull
 - companyEmail NotNull
 - companyTelephone NotNull

#### Removals Address
 - addressId _PK
 - addressLine1 NotNull
 - addressLine2
 - addressTown NotNull
 - addressCounty NotNull
 - addressPostcode NotNull
 - addressEmail NotNull
 - addressTelephone NotNull
 - companyId _FK NotNull
