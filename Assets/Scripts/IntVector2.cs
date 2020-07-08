using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct IntVector2 : IEquatable<IntVector2>
{
    public int x { get; set; }
    public int y { get; set; }

    public IntVector2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public bool Equals(IntVector2 other) 
    { 
        if (other == null)
        { 
            return false; 
        } 
        else
        { 
            return this.x == other.x && this.y == other.y;
        } 
    } 

    public override bool Equals(System.Object obj) 
    { 
        if (obj is IntVector2 other)
        {
            return this.Equals(other);
        }
        else
        {
            return false;
        }
    } 

    public override int GetHashCode() => $"{this.x}:{this.y}".GetHashCode();

    public static bool operator ==(IntVector2 left, IntVector2 right)
    { 
        if ((left as object) == null)
        {
            if ((right as object) == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return left.Equals(right);
        }
    } 

    public static bool operator !=(IntVector2 security1, IntVector2 security2) 
    { 
        return !(security1 == security2); 
    }

    public static IntVector2 operator +(IntVector2 left, IntVector2 right) => new IntVector2(left.x + right.x, left.y + right.y);
    public static IntVector2 operator -(IntVector2 left, IntVector2 right) => new IntVector2(left.x - right.x, left.y - right.y);

    public override string ToString() => $"IntVector2({this.x}, {this.y})"; 
}
