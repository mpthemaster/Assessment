# Assessment
 A simple JSON API for finding the closest robot to move a pallet or load.
<hr/>

# Instructions to Run
Runtime is .NET 6.0

1. Clone this repo.
2. Import/Open with Visual Studio 2022.
3. Run it through the IDE.
4. Access the endpoint via:
* Use Postman or some similar restclient to manually hit the endpoint at https://localhost:5001/api/robots/closest/ and http://localhost:5000/api/robots/closest/ as a post request. See below for the request and response formatting.

* Use the swagger UI that pops up at https://localhost:5001/swagger/index.html, though that only hits the 5001 port when hitting the API endpoint.

To send requests to the api via the swagger UI, select this dropdown:
![image](https://user-images.githubusercontent.com/1058149/197287673-9f2031dc-483a-4f7d-85fc-fc6baf14a48d.png)

Then click on this "Try it out" button to modify the request body and send some requests to the API!
![image](https://user-images.githubusercontent.com/1058149/197288064-db7bdc5c-1811-4c04-85f2-3bd41cec35d8.png)

: D
![image](https://user-images.githubusercontent.com/1058149/197288380-a0d9f590-16c1-4777-90f8-99fd293533b5.png)


<hr />

# Expected JSON Request and Response Format

### Note: The loadId and robotId are actually strings. I changed this to match the Robot Fleet API's response (https://60c8ed887dafc90017ffbd56.mockapi.io/robots). Maybe IDs can start with '0's, which converting to number data types would remove any leading zeros and cause bugs**

![image](https://user-images.githubusercontent.com/1058149/197288651-ace631a1-63ca-4146-b34c-7952eb66654a.png)


<hr/>

# Next Steps


