# ExamInterview

 ![image](https://user-images.githubusercontent.com/116065557/216813015-11179e48-b151-4e35-a7ab-1c11f109f0ef.png)

Window Application + SQL Database by visual studio 2022 (C# .net6)
I  embed the database in VSStudio for easy opening.
 
1.	Create accounts for customers. As it is a bank account, it has to be identified with an IBAN number. To generate that IBAN, use this website http://randomiban.com/?country=Netherlands to get a random IBAN. 

Database
 ![image](https://user-images.githubusercontent.com/116065557/216813028-4c2ed813-04de-4e7e-9683-418321eb501a.png)


GUI
 ![image](https://user-images.githubusercontent.com/116065557/216813031-d8977c63-2ba0-497e-ad5e-05ac2843270b.png)



Insert IBAN And AccountName (AccountName for communicate with customer)then click Register 
 
2.	Put money on accounts (when they deposit it in the bank) a. for each deposit, a 0.1% fee is charged (eg. 1000 is deposited, then put only 999 on the target account)

![image](https://user-images.githubusercontent.com/116065557/216813039-57167ed6-e2ae-439f-9a23-2235d74ae743.png)

 
GUI: in This Pic: selects the current customer account on combobox and then click the deposited button to deposit 1000 fee0.1% =Balance is 999.00.

 ![image](https://user-images.githubusercontent.com/116065557/216813050-5d93b015-e98c-45f5-84fa-5d5b2b06524e.png)

Database : I design to keep all TAX data in TransactionDB.



3.Transfer money from one account to another one (within our system, between our customers’ accounts)  
![image](https://user-images.githubusercontent.com/116065557/216813065-c3bdc0a0-43fc-4a4d-b863-5a51c5d5d0da.png)

Select the account to transfer money on comboBox, 
then put money on the transfer to another account on numeric (that customer can input data to transfer not over a balance from Customer Account in Example Max is 499 )
, After that click Transfer.

 
Problem : 
1.	Create accounts for customers. As it is a bank account, it has to be identified with an IBAN number. To generate that IBAN, use this website http://randomiban.com/?country=Netherlands to get a random IBAN. 
In my design, I plan to get IBAN data from http://randomiban.com automatically.
But I can’t get IBAN data.

This picture has data on the website.
 
 ![image](https://user-images.githubusercontent.com/116065557/216813075-c4e46319-056a-4586-9778-734d1059faee.png)

![image](https://user-images.githubusercontent.com/116065557/216813081-aaee7c2c-b490-4d0f-b922-c7d4e0de1903.png)

I can’t access to get IBAN from  http://randomiban.com .

This picture is from a real website.



