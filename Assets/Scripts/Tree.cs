using UnityEngine;

public class Tree : MonoBehaviour {

     //* A tree clicker game
     //* 
     //* Two levels of play: Individual tree level and the forest level
     //* Players can control three parts of the tree in two dimensions each
     //* Roots can be either extended or convoluted
     //* The branches can be extended or convoluted
     //* The trunk can be long and thin or shorter and thicker
     //* 
     //* The growing environment impacts which kind of trees thrive best
     //* 
     //* The pace of the game is casual and gentle
     //* 
     //* Visually there should be buttons on the sides of the mobile screen 
     //* A box of key stats on the top
     //* 
     //* It would be great if the tree itself was a voxel one, procedurally generated based on the choices 
     //* 
     //* 
     //* At the higher forest level there should be delineated circle domains each with their own characteristics
     //* which are combination of three factors (?) perhaps wetness, sunshine and soil quality
     //* 
  
    int roots = 0;
    int rootLength = 0;
    int rootConvolution = 0;
    int trunk = 0;
    int branches = 0;

    public int Branches
    {
        get
        {
            return branches;
        }

        set
        {
            branches = value;
        }
    }

    public int Trunk
    {
        get
        {
            return trunk;
        }

        set
        {
            trunk = value;
        }
    }

    public int RootLength
    {
        get
        {
            return rootLength;
        }

        set
        {
            rootLength = value;
        }
    }
        
    void AddToRoot()
    {
        roots += 1;
    }
        
    
    
}
