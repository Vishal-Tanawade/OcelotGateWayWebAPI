# OcelotGateWayWebAPI
### Micro-Services 
- Date: 7-June-2022
- 1st create a Blank Solution and add three projects(ASP .Net Core Web API) into it

After Last Commit (d7ed7886818b2fd6f068cb712cefaa916efa7245) Run Poject on console app=> 

- Do following for all three projects:
<img width="431" alt="image" src="https://user-images.githubusercontent.com/58319263/172355118-74ce4044-9fa3-4364-bc1e-d58dcfb00800.png">
<img width="386" alt="image" src="https://user-images.githubusercontent.com/58319263/172354902-d5c16df6-7c3f-4fd8-966d-6a37ee608471.png">
- Now Run Project
- Now Open PostMan and paste Url As shown below:

## For Get Method (GenuineCustomer):
- http://localhost:7002/api/GenuineCustomer/
![Screenshot (275)](https://user-images.githubusercontent.com/58319263/172355559-5b467f07-db5a-4b5e-94bf-f9ed8d5e054c.png)

## For Get Method (ComputerProducts):
- http://localhost:7001/api/ComputerProducts
![Screenshot (276)](https://user-images.githubusercontent.com/58319263/172355710-44381937-bac3-4704-875f-4be68afe5f6d.png)

## For Get Method (GateWay):
- http://localhost:7000/ComputerProducts-service/ComputerProducts
![Screenshot (277)](https://user-images.githubusercontent.com/58319263/172355731-bc0fac66-76b3-4d69-938d-d8e3e6e57b37.png)

## For Post Method (Gateway):
- http://localhost:7000/ComputerProductsAdd-service/ComputerProducts
![Screenshot (278)](https://user-images.githubusercontent.com/58319263/172355745-1e8fba23-3a6f-480e-9a6c-652702f4f0ed.png)



