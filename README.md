------------------------------MKP-Bank------------------------------------

*Here we are created a console application for Bank project.

------------------Class, Abstract class and Interfaces--------------------
*In this Bank Project has one abstract class(Account).
*One Interface(ITransferable).
*Two derived class (SavingsAccount, CheckingAccount) derived from Account abstract class.
*SavingsAccount also derived from ITransferable interface.
*And two class(Bank and Customer)
*And three class for exception handling(CustomerLimitationException, AccountLimitException, OverdrafException).


-------------------Datafields and Methods in Class, Abstract class and Interfaces----------------
*Account 	    - Datafields 		- accountID, it is Guid type.
						- balance, it is double data type.
	   	    - Methods 		- Withdraw and Deposit are declared with virtual.
	   	    -Abstract Method 	- Display is a abstract method.

*ITransferable 				- Transfer method

*SavingsAccount - Datafields  	- interestRate, it is double data type.
		    - Methods 		- Overrided the display method from account abstract class.
		    				- Here Transfer method is defined, It is in ITransfer interface.

*CheckingAccount - Datafields 	- overdraftBalance, it is double data type. 
		     - Methods 		- Overrided the display method from account abstract class.

*Bank 	     - Datafields 	- MAXCUSTOMERS, it is a constant integer.
						- customers, it is a list type of Customer class.
		     - Methods		- AddCustomer, it is used to add customer by firstName and lastName.
						- GenerateReport, it is used to display the report of the Bank.
						- GetCustomer, it is used to get the particular customer details and display by getting the firstName and lastName.
						- ToString(), this method override from the buildin function ToString(). It is used to display Bank name and Number of customers.

*Customer	     - Datafields		- MAXACCOUNTS, it is a constant integer.
						- accounts, it is a list type of Account class.
						- customerId, it is Guid type.
						- firstName, it is string type.
						- lastName, it is string type.
		     - Methods		- AddAccount, it is used to add account by account class type.
						- GetAccount, this method is used to get all the accounts of the customer.
						- GetFirstTransferable, this method is used to get the first transferable account of the customer.

*CustomerLimitationException
		     - Datafields		- numOfCustomers, it is int data type.

*AccountLimitException
		     - Datafields		- numOfAccounts, it is int data type.

*OverdrafException
		     - Datafields		- overdraftBalance, it is double data type.

-----------------Main(Program)-----------------
*First we need to create bank.
*So, we Create instance for Bank in try block and the catch block with exception.(Creating Bank)
*And Declare two classes customer and account.

*Then we need to add customers.
*So, We Add two customers by using AddCustomer method in another try block inside the first try block and catch block with CustomerLimitException.
*This CustomerLimitException exception catch the exception when maximum number of customer reach.

*Then We need add account to the customer.
*First we add two account for first customer.
*One is SavingsAccount, another one is CheckingAccount.
*So we get the first customer by using the GetCustomer method with first customers firstName and lastName in parameter in another try block and the catch block with AccountLimitException.
*This AccountLimitException exception catch the exception when maximum number of account reach.
*Then by AddAccount method we add savings account for the first customer by passing new SavingsAccount parameter.
*Same things for adding CheckingAccount.
*Now We add checking account for the first customer by AddAccount method with new CheckingAccount parameter.
*Next we need add account for the second customer.
*that is Joint Account with first customers checking account.
*So we get the second customer by using the GetCustomer method with second customers firstName and lastName in parameter.
*Then by AddAccount method we add checking account for the second customer that is joint account.
*Because of joint account we pass first customers checking account inside the parameter.
*by get the first customer by using the GetCustomer method 
*and get all the accounts of the first customer by GetAccount method.
*and get the first CheckingAccount of the first customer by checking the accounts it is CheckingAccount or not by Lamda expression.

*Bank accounts main use is Deposit and Withdraw.
*So now we check the withdraw and deposit.
*Now we need to deposit and withdraw money from first customers checking account.
*So we first get the first customer by using GetCustomer method.
*And assign the first customer value to customer variable Customer class type
*Then we get the Checking account of the customer.
*by using customer variable. GetAccount method with lamda expression for checking first CheckingAccount.
*And assingn the first CheckingAccount value to account variable Account type.
*Now we withdraw money using the Withdraw method inside another try block and the catch block with OverdrafException.
*This OverdrafException exception catch the exception when user try to withdraw money more than balance.
*Then we deposit money using Deposit method.
*And now we try to withdraw more than balace.
*It catch that exception.
*Here we use finally block for display the customer's first name and name.
*And display account details using Display method.

*Now we do the same thing for the second customer.

*Another use of Bank account is transfer money from one account to another account.
*So, Now we transfer money from first customers SavingsAccount to Second Customers account.
*So, we get the first customer data in customer variable by using GetCustomer method.
*Now we need the first customer's transferable account because we need to transfer money.
*So, now we use GetTransferable method. this method first get all accounts of the customer.
*And return the first account which inherited from ITransferable interface.
*And change the account datatype to transferable it is ITransferable datatype. I
*Now we transfer amount from transferable to account(now account value is second customers account) by using transfer method inside another try block and 
	catch block with OverdrafException.
*This OverdrafException exception catch the exception when user try to transfer money more than balance.
*Transfer method first withdraw money from the transferable account.
*And Deposit that money to the account.
*Here also we use finally block for display the customer's first name and name.
*And display account details using Display method.

