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