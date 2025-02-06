# Application Summary
This application is intended to model factory cycle time based on a system of nodes and links between them, based on product level manufacturing paths. Originally used as a tactical prediction tool for a semiconductor manufacturing (all sensitive data is removed) but can be generalized to any environment and product/industry.

The method of calculating expected CT is done through a DES (discrete event simulation) by taking in capacity metrics (Availability, Run Rate, etc.) and velocity data (Process Time, Queue Time, etc.). The actual performance data is used to calculate variances in these planned goals. The application can be fed a unique product mix or can use normal distributions to then simulate the flow over a user-input timeframe or default timeframe. The product mix and volumes of units can be adjusted over that timeframe to simulate a ramping production environment. 

The output of this simulation can be used to show current bottlenecks and the root cause of that bottelneck. It will also provide an expected throughput time for any product to leave the production floor to the customer. 
# Current Features

# In Progress Features

# Goal Features
* Simulate a production floor for one or multiple products
	- Single ramp point or multiple within the given timeframe
* Output multiple metrics goal and simulated values based on provided by user and pulled in from capacity modeling system
* Provide direction to close bottleneck points in product flows and give potential solutions to limiters

# How to use

# Important Links

