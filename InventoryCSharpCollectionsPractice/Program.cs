
// Lists
List<string> itemNames = [
    "Azam Soyalite Cooking Oil", // classic item
    "Illovo Brown Sugar",
    "Illovo White Sugar",
    "Rabs Salt",
    "Cerebros Salt",
    "Go Fresh Limited Whole Chicken Large"
    ];
itemNames.Add("Colgate Mint Toothpaste");

// Arrays
string[] users = new string[4];
users[0] = "Thomas";
users[1] = "Michael";
users[2] = "Andrew";
users[3] = "Svendsonn";

// Queues
Queue<string> customersQueue = new Queue<string>();
customersQueue.Enqueue("Bob");
customersQueue.Enqueue("Jeremiah");
customersQueue.Enqueue("Jonathon");
customersQueue.Enqueue("Joshua");

string firstCustomer = customersQueue.Dequeue();

// Stacks
// Strange example but whatever
Stack<string> freshFruits = new Stack<string>();
freshFruits.Push("bad fruits");
freshFruits.Push("better fruits");
freshFruits.Push("better better fruits");
freshFruits.Push("good fruits");
freshFruits.Push("best fruits");

freshFruits.Pop(); // best fruits taken! 

// Dictionaries
Dictionary<string, int> sellingPrices = new() 
{
    ["Azam Soyalite Cooking Oil"] = 15_000,
    ["Illovo Brown Sugar"] = 7_500,
    ["Kukoma Cooking Oil"] = 13_500
};
sellingPrices.Add("Colgate Soft Toothbrush", 6_000);
