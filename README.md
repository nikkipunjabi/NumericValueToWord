
## Numeric Value To Word

This application can be used to convert numeric value to word in C#.
We are using the Dollar currency. So any value given by a user will be converted to a dollar amount in words.
It's a simple application written in .NET Framework


This application is created in Visual Studio 2017 on .NET Framework 4.6.1. Also I have created a web-service which will be called via Ajax request and display the output response in the browser. 
I've used Bootstrap to create a simple UI. HTML5 and jQuery Form Validation for the client side validations.

#### Quick start:

  - In order to run this application, please clone this repository
  - Run the .sln file in Visual Studio
  - Clean and Rebuild the solution.
  - Debug - Start Debugging (or F5) from Visual Studio

![Start-Debugging](http://www.nikkipunjabi.com/Sitecore/numericvaluetoword/start-debugging.png)

_If you get an error for roslyn compiler in the browser, kindly clean and rebuild the solution and again start debugging._

#### How it works:
-   We have a form on the browser.
-   User will provide the required details.
-   On click of submit button client-side validation occurs.
-   If all good from the client-side the given data will go to the server via Ajax Request.
-   A webservice will be called through Ajax Request.
-   Service will do all the back-end processing to convert the given value.
	-   I've created a Helper class for the service to do the back-end processing.
	-   The given value will be converted to an Integer data type which accepts maximum 2147483647. So I've restricted this from the client side to send only the value which the server can process. We can quickly do some update to increase the number. You'll have to do some change in the code.
-   A given output response from the service will be sent back to the request.
	-   Service can give the proper output or error message in the response.
-   Based on the response data will be shown on the browser.

#### Output:
![Start-Debugging](http://www.nikkipunjabi.com/Sitecore/numericvaluetoword/output-1.png)


![Start-Debugging](http://www.nikkipunjabi.com/Sitecore/numericvaluetoword/output-1.png)

#### Unit Test Project:
In order to run the test case in visual studio -- You might will have to update the webservice reference initially in the visual studio.


![Start-Debugging](http://www.nikkipunjabi.com/Sitecore/numericvaluetoword/update-service-reference.png)

And then you should be easily able to execute the test-cases.
In order to run all the test-cases -- click Run All in the Test Explorer


![Start-Debugging](http://www.nikkipunjabi.com/Sitecore/numericvaluetoword/run-test-cases.png)

Test Cases:
1)     123.45
   Output: one hundred and twenty-three dollars and forty-five cents
2)     22.22
   Output: twenty-two dollars and twenty-two cents
3)     100
   Output: one hundred dollars
4)     1
   Output: one dollar
5)     1.01
   Output: one dollar and one cent
6)     1.10
    Output: one dollar and ten cents
7)     2.2
   Output: two dollars and twenty cents
8)     555.55
   Output: five hundred and fifty-five dollars and fifty-five cents
