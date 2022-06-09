/* Intentionally skimming over this pattern because 
 * the built-in Unity Instantiate function for MonoBehaviours
 * uses prototypes for cloning. The pattern is already taken care
 * of by Unity.
 * 
 * Reason to use Prototypes generally:
 * 
 * Main benefit of it is imparting state at the same time 
 * as instance creation (i.e. cloning from an existing prototype).
 * 
 * Done by adding a clone function to prototype class. Object to be 
 * duplicated passes state to new object at the time of instantiation.
 * 
 * The spawner will contain the prototype to know what it needs to spawn.
 */

/* Experimented with using scriptable objects.
 * Effectively data storage in the hierarchy, useful when some shared state is needed.
 * Prototype pattern copies state to new clones, but this isn't even necessary if they
 * all share state using a reference to a scriptable object data store in the project
 * data. 
 * 
 * Scriptable objects make it easy to separate the prefab (GO, sprites, scipts etc.) from
 * the state that the object must have. This way we can re-use prefabs, giving them different states.
 * The state of the object is not tied to the prefab, removing the need for the prefab to be duplicated 
 * over and over again with just one or two variables changed.  
 * 
 * Note: Changing Scriptable Object while the game is running, changes the data perminantly.
 * It is not an object of the scene, but rather an object of the project. This way we don't have
 * to worry about losing state when the project closes. 
 */