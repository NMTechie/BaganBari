## EdTech platform 

Epics:
 - Social Login (github/linkedin)
 - Search (Catalog - Path/course/topic/certification)
 - Profile
 - Payment
 - Invoice
 - License
 - Enrollement 
 - Notifications
 - Goal
 - Advertisement/Camping/Digital Marketing
 
 
 # Training Problem Statement 
 Assumption :
 
 1. Training Catalouge (Search & Filter)
	1.1 Trainer Profile
 2.  Search of Training Result - Total time , Cost, *Review feedback*
 3.  Details of Training - Curriculam , Total time , Cost, Review feedback, description, *Author credibility* , key outcome
 
 Bounded Context - User Management
 
 Bounded Context - Trainer Management
 a. Trainer aval calendar 

 Bounded Context - Search 
 
 Bounded Context - Training (Curriculam , Total time , Cost, description, no of participant ,key outcome assume pre-exisits)
 a. Trainging avl calendar
 b. Quotation (When no of participant is > than pre-defined offering)
 
 
 ------------------------------------------------------------------------------------------------------------------------------
 4.  Trainging Purchase - Book Slot (no. of participant)-> Payment -> Invoice -> Notification
	4.1 Trainging Purchase - Slot change request -> Notification
		Trainging Purchase - Pre-requisite -> Notification -> Tracking -> Notification
		Trainging Purchase - no. of participant -> Payment -> Invoice -> Notification
		4.2 Trainging Cancel - Refund -> Invoice -> Notification
--------------------------------------------------------------------------------------------------------------------------------
 5. Trainging Closure -> feedback Submission by participant -> Notification
	5.1 Trainging Closure -> Payback to Trainer -> Notification
 
 
 # Problem Statement - (Course sub domain)
 1. Course(s) already exist.
  


