# Assessment
 A simple JSON API that calculates which robot should transport a pallet from point A to point B based on which robot is the closest and has the most battery left if there are multiple in the proximity of the load's location.
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

### Note: The loadId and robotId are actually strings. I changed this to match the Robot Fleet API's response (https://60c8ed887dafc90017ffbd56.mockapi.io/robots). I am not sure how IDs are constrained, so if any were to start with '0's or have letters, which converting to number data types would remove any leading zeros and cause bugs**

![image](https://user-images.githubusercontent.com/1058149/197288651-ace631a1-63ca-4146-b34c-7952eb66654a.png)


<hr/>

# Next Steps
1. Adding authentication with API tokens.
2. Whether this API is running in the cloud or at a physical location, it may need to account for building locations, or even floors within a building. So, a location, or floor within a building may need to be specified.
3. Using HTTPS only to encrypt data in transit to protect any credentials (API token, user name, etc.) if authentication is used.
4. Check not only the battery life of the closest robots to a pallet, but also simulate how far the pallet needs to be moved to see if the robot has enough battery level left to complete the task. In this case, also take into account the weight of the pallets, as heavier pallets probably drain batteries faster than light ones.
5. For a realworld scenario, robots already doing a task should be excluded from checking which one is closest to the pallet.
6. Robot pallet moving efficiency may be improved by not routing for just 1 pallet, but routing for a series of pallets. Like how delivery trucks are routed for optimal delivery. 
7. Validate submitted input and have better error-handling (including for the request to the robot fleet API provided).
8. Add logging for debugging using the logger.
9. Add unit testing.
10. For scalability, data types can be optimized and threading can be tuned.
11. Change the hardcoded URI for the Robot Fleet API to a configuration file instead.
12. I ran out of time, but I ran into a bug with my OOP due to the JSON property names for ids being different. Instead of them all being id, they are "loadId", "robotId", etc., and this caused a binding issue with the deserialization constructor where it was trying to bind the parent class's virtual property of ID with the children's id properties overriding them (I overrode them so I could specificy the JSON property names to be "loadId", "robotId" so they would match the requirements. When writing APIs I am used to the json names and the property names to just be "ID", so I never encountered this issue before. I was making progress on solving this more elegently, but in the interest of time I ended up removing id from the parent class so it would work.
13. You can see how the OOP is starting to be abstracted, not quite there as I don't understand the context of the other APIs and other activities the robots may be doing. Do they move more than pallets? Do they do more tasks than moving pallets? What other objects do they work with? The code I wrote is in the beginning stages of being able to handle these other concepts if they were needed. Reminds me a lot like video game design.

