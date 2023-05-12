public static class StoryFiller
{
    public static StoryNode FillStory()
    {
    var root = CreateNode(
        "You wake up in a strange room with no memory of how you got there. " +
        "The door is locked and the window is sealed shut. " +
        "You need to find a way out.",
        new [] {
            "Examine the room",
            "Sit for a while longer to regain your senses"
        }
    );
    var node1 = CreateNode(
        "The room is bare except for a small desk and a chair. " +
        "There is a drawer on the desk and a piece of paper lying on top.",
        new [] {
            "Inspect the drawer",
            "Read the paper",
            "Explore the rest of the room"
        }
    );

    var node2 = CreateNode(
        "The drawer is empty except for a small key hidden in the back.",
        new [] {
            "Take the key",
            "Leave it"
        }
    );

    var node3 = CreateNode(
        "The paper reads: 'The key to your escape lies within the room.' " +
        "It doesn't make much sense to you.",
        new [] {
            "Explore the rest of the room", 
            "Keep exploring."
        }
    );

    var node4 = CreateNode(
        "There is a painting on the wall with a small safe hidden behind it. " +
        "You need a combination to open it.",
        new [] {
            "Look for clues",
            "Try to guess the combination"
        }
    );

    var node4b = CreateNode(
        "You tried guessing a random combination and the safe did not open." +
        "You need to try to find the right combination.",
        new [] {
            "Look for clues",
            "Guess the combination again"
        }
    );

    var node5 = CreateNode(
        "You notice that the books on the shelf are arranged in a certain order. " +
        "Maybe it's a clue?",
        new [] {
            "Inspect the books", 
            "Think about it for a bit."
        }
    );

    var node6 = CreateNode(
        "You find a torn piece of paper hidden between two books. " +
        "It reads: '2, 6, 9'. " +
        "You're not sure what it means.",
        new [] {
            "Try the combination on the safe", 
            "Double check the numbers again."
        }
    );

    var node7 = CreateNode(
        "The combination works! Inside the safe, you find a map and a note that reads: 'Follow the map to find your way out.'",
        new [] {
            "Take the map and note", 
            "Leave the map and note"
        }
    );

    var node8 = CreateNode(
        "The map leads you to a hidden staircase that takes you to a basement. " +
        "You hear strange noises coming from the darkness.",
        new [] {
            "Investigate the noises",
            "Ignore them and keep moving"
        }
    );

    var node9 = CreateNode(
        "You find a flashlight on the ground. It might come in handy.",
        new [] {
            "Take the flashlight",
            "Leave it"
        }
    );

var node10 = CreateNode(
    "You find a locked door. There's a note taped to it that reads: 'The key to your freedom lies beyond this door.'",
    new [] {
        "Search for the key",
        "Try to break down the door"
    }
);

var node10b = CreateNode(
    "You tried kicking down the door but it failed to open.",
    new [] {
        "Search for the key",
        "Try kicking the door again"   
    }
);

var node11 = CreateNode(
    "You find the key hidden in a nearby toolbox. " +
    "You unlock the door and step outside, free at last!",
    new [] {
        "End the game",
        "Play again"
    }
);


    root.NextNode[0] = node1;
    root.NextNode[1] = node1;
    
    node1.NextNode[0] = node2;
    node1.NextNode[1] = node3;
    node1.NextNode[2] = node4;

    node2.NextNode[0] = node4;
    node2.NextNode[1] = node1;

    node3.NextNode[0] = node4;
    node3.NextNode[1] = node4; 

    node4.NextNode[0] = node5;
    node4.NextNode[1] = node4b;

    node4b.NextNode[0] = node5;
    node4b.NextNode[1] = node4b;

    node5.NextNode[0] = node6;
    node5.NextNode[1] = node5;

    node6.NextNode[0] = node7;
    node6.NextNode[1] = node6;

    node7.NextNode[0] = node8;
    node7.NextNode[1] = node9;

    node8.NextNode[0] = node9;
    node8.NextNode[1] = node9;

    node9.NextNode[0] = node10;
    node9.NextNode[1] = node10;

    node10.NextNode[0] = node11; 
    node10.NextNode[1] = node10b;

    node10b.NextNode[0] = node11;
    node10b.NextNode[1] = node10b;

    node11.NextNode[0] = null; 
    node11.NextNode[1] = node1;

    return root;
    }

    private static StoryNode CreateNode(string history, string[] options)
    {
        var node = new StoryNode
        {
            History = history,
            Answers = options,
            NextNode = new StoryNode[options.Length]
        };
        return node;
    }
}
