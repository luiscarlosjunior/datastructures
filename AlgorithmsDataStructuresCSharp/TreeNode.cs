using System;

namespace AlgorithmsDataStructuresCSharp
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        
        public TreeNode(T value)
        {
            Value = value;
        }
        
        public void Insert(T newValue)
        {
            int compare = newValue.CompareTo(Value);
            
            if(compare == 0)
                return;

            if(compare < 0)
            {
                if(Left == null)
                {
                    Left = new TreeNode<T>(newValue);
                }
                else
                {
                    Left.Insert(newValue);
                }
            }
            else
            {
                if(Right == null)
                {
                    Right = new TreeNode<T>(newValue);
                }
                else
                {
                    Right.Insert(newValue);
                }
            }
        }
        
        public TreeNode<T> Get(T value)
        {
            int compare = value.CompareTo(Value);
            if (compare == 0)
                return this;
            
        }
    }
}