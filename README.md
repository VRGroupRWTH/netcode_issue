This minimal sample demonstrates two bugs/breaking changes when upgrading from Netcode for Gameobjects 1.0.2 to 1.1.0:
The bugs are most likely closely related and occur due to the same reason.

1. Initial position sync for in-scene places network objects:

The right two cubes are hierachically ordered as follows:
- Parent Cube (No NetworkObject)
  - Child Cube (NetworkObject)
and stacked on each other somewhere in the scene. 
On Start(), the Parent Cube is moved from its original position to the desired one (0, 0.5, 0), 
such that the stack appeares right in front of the respective players. 
This works fine on the connecting client in 1.0.2, but in 1.1.0 only the parent cube is being moved. 

2. Initial scale sync for in-scene places network objects:

The left two cubes are hierachically ordered as follows:
- Parent Cube (No NetworkObject)
  - Scale Gameobject 
    - Scaled Child Cube (NetworkObject)
This leads to a wrongly scaled Child Cube on the Client. 
