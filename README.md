<h1 align="center"> Precision Strike - A First Player Shooting Game </h1>

<p align="center">
  <a>
    <img src="https://github.com/arjundas1/Precision-Strike/assets/72820515/07e29b4a-70ec-4e41-89c9-10c32e84aade" width="600" height="300">
  </a>
</p>

<details open="open">
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#introduction">Introduction</a></li>
    <li><a href="#project-team">Project Team</a></li>
    <li><a href="#applicability">Applicability</a></li>
    <li><a href="#tools-used">Tools Used</a></li>
    <li><a href="#process-flow">Process Flow</a></li>
    <li><a href="#methodology">Methodology</a></li>
    <li><a href="#interface-validation">Interface Validation</a></li>
    <li><a href="#goms-analysis">GOMS Analysis</a></li>
    <li><a href="#klm-model">KLM Model</a></li>
    <li><a href="#conclusion">Conclusion</a></li>
  </ol>
</details>

## Introduction

The ability to learn and consider more effectively enables a person to make better decisions, 
which equips them to handle challenging situations. A player's reflexes, vision, and 
ingenuity are enhanced by gaming. The purpose of gaming is to develop a video game that 
requires players to become proficient with a variety of weapons used by law enforcement, 
rescue personnel, and enemies. This project involves the development of a first-person 
shooter video game, a genre of video game in which combat is predominantly focused on 
the use of firearms and other weapons and is viewed through the protagonist's eyes.

We intend to concentrate on the condition of the sluggish eye, in which both eyes are unable 
to focus effectively. First-person shooter games enable the player to experience events from 
the viewpoint of the protagonist. Due to its similarity to other shooter games, this genre is 
classified as an action game. Advanced 3D and pseudo-3D graphics have been a hardware 
development challenge since the inception of the genre, and multiplayer gameplay has been 
a key factor. First-person shooters are three-dimensional sniper games with a first-person 
perspective, allowing the user to observe the action through the eyes of the player character. 
They differ from third-person shooters in that the user can typically see the character they're 
controlling from behind. Combat, which primarily entails weapons, is the design's primary 
focus.
 
## Project Team

Guidance Professor: Dr. Arup Ghosh, School of Computer Science and Engineering, VIT Vellore.

The group for our Data Mining project consists of -

|Sl.No. | Name  | ID Number |
|-| ------------- |:-------------:|
|1| Krishalaani   | 20BCE2142     |
|1| Arjun Das     | 20BDS0129     |
|2| Jay Jain      | 20BDS0286     |
|3| Arsath Wahaab | 20BDS0319     |

## Applicability

- Entertainment: FPS games provide a source of entertainment for millions of people 
around the world. Our game, being lightweight does not require very high graphics to run. 
Hence, it can prove to be a viable source of entertainment for those who do not want to 
spend heftily on gaming set-ups such as expensive laptops or gaming consoles.
- Stress relief: FPS games can provide a safe and healthy way to relieve stress. Playing an 
immersive FPS game can help players forget about their real-world problems and provide 
a sense of control and accomplishment. This can be especially helpful for individuals who 
have high-stress jobs or deal with anxiety. Hence this game can be beneficial to those 
dealing with stress and anxiety.
- Improved decision-making skills: The game requires players to make quick and effective 
decisions under pressure, which can improve decision-making skills in real-life situations. 
Players must evaluate their surroundings, analyze the situation, and make a decision that 
will help them achieve their objectives and proceed forward with the game.
- Cognitive development: FPS games require players to use a variety of cognitive skills, 
including problem-solving, memory, attention, and spatial reasoning. These skills can be 
useful in many areas of life, such as work, school, and personal relationships. Thus, this 
game can prove to be useful for cognitive development of individuals.
- Treating Amblyopia / Lazy Eye: Amblyopia is a type of poor vision that usually occurs 
in 1 eye, causing problems in focusing since both eyes cannot work together. This condition 
becomes harder to solve, especially after the age of 8 years. Even before that, it is a long 
and tedious process. Our game aims to help in the treatment of this disorder by providing 
a platform where players need to focus on targets (enemies), which spawn quickly as the 
game progresses. This, with time, improves the capability of the weak eye to focus better 
and hence, helps in treating Amblyopia.
- Improve motor skills: The game requires players to use a variety of motor skills, such as 
aiming, shooting, and moving quickly. These skills can be useful in many areas of life, 
such as sports or physical labor jobs. It can also be used by individuals with weak motor 
skills.
- Reflex development: The game requires players to react quickly to changes in their 
environment. This can help develop quick reflexes that can be useful in sports, driving, and 
other activities. It also improves hand-eye coordination and reaction time.
- Improve spatial awareness: The game requires players to have a good sense of spatial 
awareness, which is the ability to perceive the environment and understand how objects 
relate to each other in space. This can be useful in many areas of life, such as driving, 
navigation, and architecture.
- Risk assessment: The game often presents players with risks and consequences for their 
actions. Playing these games can help individuals develop better risk assessment skills, 
which can be useful in many areas of life, such as finance, business, and personal safety

## Tools Used

To achieve the project objective, we make use of the following tools and technologies –

- Unity
- Blender
- Unreal Engine
- VS Code
- GitHub
- Epic Games Launcher
- Visual Scripting
- 3D Modeling
- VFX
- C# language

## Process Flow

The game involves the following actors:
- Player
- Enemy: Boar, Cannibal
- Player Weapons
- Player, Enemy Health
- Player Stamina

The character has an option to choose from 6 weapons to use against the enemies. The player can aim and shoot the enemies. The player has motion controls which involve moving forward, backward, left & 
right, jumping, crouching, sprinting. The enemies have four states which include: Idle, Running, Attacking, and Dead state. Once the enemy notices/ detects the player it will move from idle state to running state. Once it reaches the player it will transition to an attacking state. Both the player and the enemy have a health stat. The player also has a stamina stat which decreases when the player sprints.

The workflow is defined as follows:
- Creation of the Player/ Character
- Adding Movement control and some idle animation to the character.
- Mouse Control
- Weapon Control
- Attributes/ Properties of each weapon (ex. Damages dealt)
- Bullet Speed
- Aiming Stats
- Switching between Weapons
- Enemy creation and control
- AI parameter for spawning enemies.
- Damage parameter configuration:
- Damage to enemies based on weapons used
- Damage to the player from enemies
- Damage to enemies based on accuracy of aim
- Health parameter configuration
- Creating the Map environment.
- Stats UI/ Health & Damage overlays
- Adding Sound and VFX effects.
- Creating some NPC

## Methodology

<b>Overview:</b>

1. The first step in creating a first-person shooter game in Unity is to construct a new 
project using the "3D" template. After creating a new project, you must import the 
necessary assets, such as 3D models for the protagonist character, weapons, and 
opponents, as well as textures, materials, and scripts.
2. Next, we must construct the player character or the character that the user will control 
throughout the game. The player character will require a 3D model, animations, and 
scripts to control movement and behavior. Weapons, which are the objects that the 
player will use to attack adversaries, and enemies, which are the objects that the player 
will combat against in the game, are created using the same method.
3. After constructing the necessary game elements, we must design the game's 3D levels, 
which the user will play on. We can construct levels using the Unity editor, which 
allows us to add elements, objects, and assets.
4. The next step is to add the necessary user interface elements, such as the vitality meter, 
stamina bar, and any other information the player must see. Utilizing the Unity editor, 
UI elements can be added to a game.
5. After creating the game elements and adding the necessary UI elements, we must 
evaluate the game to ensure that all elements are functioning correctly. We can test a 
game by playing it ourselves or by having others play it. During testing, we should look 
for flaws, errors, and any other issues that could negatively impact the player's 
experience.
6. Creating a first-person shooter game in Unity entails a series of stages, including the 
creation of game elements, levels, and UI elements, and evaluating the game prior to its 
release. Creating an enjoyable and engaging game is a complex process that requires
attention to detail and a creative mindset.

<b>Steps:</b>

1. The first stage in developing a game is to define the game's concept. Our game is a 
first-person shooting game that involves fighting a horde of enemies that are classified 
as cannibals and boars.
2. The next step is importing all the assets and configuring each element in the game.
3. The next step is to configure the player's character. This involves developing the 
movement, health states, damage parameters, and animations. The characters' animations 
are produced using Unity's animation tools.
4. Once the character is configured, we will configure the weapons and their respective 
animations, damages, aiming, and shooting controls.
5. To control the enemy movement, detection, and attack pattern we make use of an enemy 
manager script that uses Unity’s built in AI system to control the enemies based on 
the defined parameters.
6. Sound effects and music are essential to a first-person shooter's immersive experience. 
Now we include all the weapons sounds, character footsteps sound, enemy sounds, 
VFX has such muzzle bursts.
7. Once all the internal configurations are finished, we move on to designing the user 
interface. This involves creating the health bar, stamina bar, and WASD controls.
8. Once the interface is designed, we then create a simple start menu that provides the 
user with the option to look up the user controls or start playing the game.


## Interface Validation

### Nielsen's Heuristics

Nielsen's ten heuristics are a set of criteria for assessing user interface design. These algorithms 
may be used in a variety of software applications, including first-person shooter games. Each 
of Nielsen's ten criteria is shown here in relation to the design of fps.
- Visibility of system state: It is critical in a first-person shooting game to offer players 
with clear feedback about their status in the game. Displaying the health state and stamina 
state of the player's character.
- System-to-real-world match: In first-person shooting games, implementing 
realistic scenarios and damage models helps improve the game's immersion and 
realism. Our game's map is set in a forest which can be easily comprehended by anyone. 
Moreover, the weapons used also resemble the ones that exist in real life, for example 
shotgun, revolver, wooden spear, etc.
- User control and freedom: Giving players several methods to fulfil goals or explore 
the game environment allows them to play the game in their own manner. Our game 
allows the user to select the weapon as per their choice
- Standards and consistency: Employing consistent design and interaction patterns 
across the game might assist users in understanding how to engage with the game. For 
eg. the standard movement key binds used in fps like w for forward, and spacebar for jump 
have been used in the game.
- Error prevention: It's critical in a first-person shooting game to build the interface 
to avoid mistakes and offer clear information to players when they do occur. For 
example, when the key 'w' is pressed, it is highlighted for the player to know that he/she 
is moving forward. Also, the health bar and sprint bar reduce according to the damage 
taken and stamina which acts as feedback for the user
- Recognition rather than recall: Using identifiable signs and symbols in a first-person shooting game might assist players in rapidly comprehending the game's dynamics. 
For example, instead of forcing the user to experiment with all the key binds, employing 
proper instructions for necessary functions in-game may assist players quickly and 
readily comprehend the game's mechanics.
- Flexibility and ease of use: In a first-person shooting game, offering players with 
several methods to complete tasks and optimizing the game's interface for ease of use 
may improve the playing experience. For example, giving players alternative shooting 
modes might assist optimize the game for varied play styles.
- Aesthetic and minimalist design: Using a clean and simple UI in a first-person 
shooting games may assist players in concentrating on the game's actions and goals. Using a 
basic, uncluttered interface that accentuates the player's character and the game 
environment, for example, might assist gamers in focusing on the action. We have tried 
to achieve this using a clean and simple map for ease of comprehension for the user
- Assist users in recognizing, diagnosing, and recovering from errors: In a first-person shooting game, giving players clear feedback and instruction when a mistake 
occurs may improve the gaming experience. Providing visual or aural indicators when 
a player receives damage with the help of a health bar or using sound effects when an 
enemy dies, for example, may assist players in recognizing and recovering from 
mistakes. With the help of these visual indicators, the players can monitor their movements, 
health status and stamina status.
- Help and documentation: In a first-person shooting game, making documentation 
and assistance materials easily accessible may improve the playing experience. In-game tutorials or tooltips, for example, may assist players learn the game's mechanics 
and interface.


### Norman's Principles

Donald Norman's seven principles of design can be applied to the evaluation of the first-person 
shooter (FPS) game's user interface, as described in the provided text. Here's how each of Norman's 
principles can be related to the game's design:

- Visibility: The principle of visibility is evident in the game's display of the player's health and 
stamina status. Providing clear and easily accessible feedback about the character's status 
ensures that users are aware of their in-game condition.
- Feedback: Feedback is closely related to visibility. The game uses visual indicators like health 
and stamina bars to provide feedback to players. Additionally, it highlights the keypress (e.g., 
'w') when the player makes a move, which helps users understand their actions and whether 
they are moving in the desired direction.
- Affordance: The concept of affordance is reflected in the use of recognizable signs and 
symbols, standard movement key binds (e.g., 'w' for forward), and realistic weapon designs. 
These elements make it easier for players to understand how to interact with the game and its 
mechanics.
- Mapping: Mapping is essential in FPS games, and it's described in the text. The game's map is
set in a forest, which can be easily understood, providing a clear connection between the in-game world and the real world. This enhances the player's ability to navigate the environment 
and make sense of their surroundings.
- Constraints: While not explicitly mentioned in the text, the use of standard key binds and the 
availability of multiple weapon choices provide constraints that guide the player's actions and 
decisions. These constraints help prevent accidental or unintended actions.
- Consistency: The game maintains consistency in design and interaction patterns. It uses 
standard FPS movement controls (e.g., 'w' for forward) and provides clear instructions for 
essential functions, ensuring that players can easily recognize and recall how to interact with 
the game.
- Simplicity: The text indicates that the game aims for a clean and simple user interface, which 
aligns with the principle of simplicity. Aesthetic and minimalist design is mentioned as a way 
to help players focus on the game's actions and goals, reducing cognitive load.

These principles are applied to create an interface that is both intuitive and engaging for players.

## GOMS Analysis

<b>Goals:</b>
1. Create a user-friendly interface for a first-person shooting game.
2. Enhance the gaming experience by aligning with Nielsen's heuristics.

<b>Operators and Methods:

Visibility of System State:</b>
- Method: Display the health and stamina status of the player's character.

<b>System-to-Real-World Match:</b>
- Method: Implement realistic scenarios and damage models in a forest environment, 
using real-life weapons.

<b>User Control and Freedom:</b>
- Method: Allow players to choose their weapons according to their preferences.

<b>Standards and Consistency:</b>
- Method: Use standard FPS movement key binds (e.g., 'w' for forward, spacebar for 
jump) for consistency.

<b>Error Prevention:</b>
- Method: Highlight the key ('w') when pressed to confirm the player's action.
- Method: Provide health and stamina bars that decrease when the character takes 
damage, offering clear feedback.

<b>Recognition Rather Than Recall:</b>
- Method: Use identifiable signs and symbols, and provide clear instructions for key 
functions to facilitate a quick understanding of the game's mechanics.

<b>Flexibility and Ease of Use:</b>
- Method: Offer multiple methods for completing tasks, such as alternative shooting 
modes, to accommodate various play styles.

<b>Aesthetic and Minimalist Design:</b>
- Method: Use a clean and simple UI to focus players' attention on the game's actions and 
goals.
- Method: Utilize a clean and simple map for easy comprehension.

<b>Assist Users in Recognizing, Diagnosing, and Recovering from Errors:</b>
- Method: Provide visual indicators (health bar) and sound effects (enemy death) to help 
players recognize and recover from mistakes.

<b>Help and Documentation:</b>
- Method: Make in-game tutorials and tooltips easily accessible to assist players in 
learning the game's mechanics and interface.

<b>Selection Rules:</b>
The selection of methods aligns with the specific heuristic goals, ensuring that the user interface 
design adheres to Nielsen's heuristics.
Methods are chosen to enhance user interaction, understanding, and error recovery within the FPS 
game.

The GOMS analysis of the text shows how the design of the FPS game's user interface 
aligns with Nielsen's heuristics by applying specific operators and methods to achieve the goals of 
creating a user-friendly and immersive gaming experience. The selection of these methods follows the
principles set forth by Nielsen's heuristics, ensuring a comprehensive evaluation and enhancement of 
the game's interface design

## KLM Model

The KLM (Keystroke-Level Model) is a way to estimate the time it takes for a user to perform 
tasks based on the number of keystrokes or actions required.
KLM model estimating the time it might take a user to perform certain actions in this game:

- Aim and Shoot (single target):
<br>K (Keystroke) - Move the mouse to aim: 1
<br>P (Pointing) - Aim: 1.1 seconds
<br>K (Keystroke) - Shoot: 1
<br>Time = K + P + K = 1 + 1.1 + 1 = 3.1 seconds

- Switch Weapon:
<br>K (Keystroke) - Press weapon switch key: 1
<br>Time = K = 1 second

- Reload:
<br>K (Keystroke) - Press reload key: 1
<br>Time = K = 1 second

- Navigate Menu:
<br>K (Keystroke) - Navigate through the menu (per selection): 1
<br>Time = K = 1 second per selection

- Navigate Inventory:
<br>K (Keystroke) - Navigate through inventory items (per selection): 1
<br>Time = K = 1 second per selection

## Conclusion

In conclusion, the FPS game project for human-computer interaction subject was a success. 
The game was well-received by the students, and it helped them to learn about the 
principles of human-computer interaction in a fun and interactive way. The game was also 
able to teach the students about the importance of teamwork and communication.

There are several ways that the project could be improved in the future. One possibility 
would be to add more levels to the game. This would allow the students to play the game 
for longer and would also give them a chance to learn more about the different aspects of 
human-computer interaction. Another possibility would be to add more features to the 
game. This could include things like leaderboards, achievements, and online multiplayer. 
These features would make the game more challenging and would also allow the students 
to compete.

Overall, the FPS game project for human-computer interaction subject was a success. The 
game was well-received by the students, and it helped them to learn about the principles of 
human-computer interaction in a fun and interactive way. The game also helped the 
students to learn about the importance of teamwork and communication. There are several 
ways that the project could be improved in the future, but it is a good starting point for a 
project of this nature.

Here are some of the future scopes for the project:
- Adding more levels to the game: This would allow the students to play the game 
for longer and would also give them a chance to learn more about the different 
aspects of human-computer interaction.
- Adding more features to the game: This could include things like leaderboards, 
achievements, and online multiplayer. These features would make the game more 
challenging and would also allow the students to compete.
- Making the game more realistic: This could be done by adding more detailed 
graphics and by making the game physics more realistic.
- Making the game more challenging: This could be done by adding more enemies, 
making the enemies more intelligent, or making the levels more difficult.
- Making the game more social: This could be done by adding multiplayer features 
or by allowing the players to communicate with each other.
- Making the game more educational: This could be done by adding educational 
content to the game or by making the game more challenging.
