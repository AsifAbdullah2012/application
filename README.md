# Application task

Thank you for applying to our job offering.
In the following are a bunch of tasks which could appear in a similar kind in your upcoming workload.
The first part contains general questions.
Please answer the questions after forking this repo and keep it private.
The second part asks for a common git scenarios.
The third part requires implementation tasks.

## Part 1: Questions

Please answer the following quesitons shortly inside this file.

### Why is health data such as this especially protected by the data protection and privacy regulations?

- Health data is personal and very sensitive and it must be handled confidentially. Patient data is very confidential because it tells which disease (diabetes, heart blockage) the patient might have. This information is sensitive and must not be shared publicly. If this data is leaked the patient might face severe problems in his personal and social life. Nowadays, healthcare infrastructure is being digitalized and modern technology is used to identify diseases more accurately and in the early stages. Due to this reason, more data is generated and more care is needed for data protection and privacy. For example, on-premise infrastructure is used for data storage and processing instead of using cloud providers. 

### How do you provide animation logic in Unity-based game?

- In unity animation, state machine concept is important. There are states, events, transitions in the state machine. For example: a player is idle that means it is in the idle state and when it is in a state an animation clip is played which is based on framesrate or time. So, in an idle state the player will perform the clip in a loop. When we press the button for run the player will run because pressing will make the speed > 0 (for example) and it will go to the run state as the transition from idle to run condition is fulfilled. In the run state the player will play a run clip (which contains several images that will mimic the run) until the condition is fulfilled. When the player releases the key that means speed == 0 and then from run state the player will go to the idle state. That is the basic concept of making animation in Unity. I have small knowledge in case of game development but I have worked with state machines (for example sismic Framework) during my master thesis. 

### Please explain how file permissions work in Linux. What different kinds of permissions are there? How are they assigned to a file or directory?

- File permission is crucial for security and privacy. Linux divides its permission for three category owner (owns the file), group (users who can access the file) and user (all other users). Each file or directory has three kind permissions read (r), write (w) and execute (x). With read permission the user can only view the file, with write permission he can edit or rename the file and with execute permission he can execute the file (in case of scripts). For example, If a user has only read permission for an specific file that means he can only view the file can not write, rename or execute the file. In an specific directory ls -l comnnad show the file names and permissions for each group. In case of assigning permission change mode (chmod) is used. This is the structure for assigning permission 'chmod [which_group][operator][permission] file/directory'. these are the alphabets for each group. u (owner), g (group), o (others), a (all). For example 'chmod u+x file1' will give the owner execute permission for that specific file. At Fraunhofer HHI we worked on Linux based development server. In case of HPC cluster the headnode was also linux based where we have access limit to certain files or folders.  

 

 
## Part 2: Git skills

Git is a common tool to keep track of code development and collaborative programming.
Before continuing please commit your answers so far, thanks.

### Git merge

If you check the branches of this repository you will recognize another branch.
Please merge the branch and its containing files into your main branch.
Resolve possible merge conflicts.


## Part 3: Simple demo app

### Implementation task

Create an android app which allows the user to register a patient with firstname, lastname, date of birth, weight, shoesize. Additionally the app should instruct the user to take four pictures of the patients feet, the top and bottom per foot. The backend can be mocked and does not have to be implemented by you. However, it should ideally be a REST API endpoint.

### What privacy issues are related to this feature?

- Here we are taking information of the patient and also photos of his foot. This information is sensitive. For example, a health insurance company when contacted with them asks about the last name and date of birth. As scammers if they have the information might call the patient and tell his last name and date of birth and pretend to be the health insurance company. So, for these reasons any data should be dealt carefully. 
