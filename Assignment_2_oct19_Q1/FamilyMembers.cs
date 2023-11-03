﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class FamilyMember
    {
       

            public string Name { get; set; }
            public int Age { get; set; }
            public List<FamilyMember> Children { get; set; }

            public FamilyMember(string name, int age)
            {
                Name = name;
                Age = age;
                Children = new List<FamilyMember>();
            }

            public void AddChild(FamilyMember child)
            {
                Children.Add(child);
            }
        }

        class FamilyTree
        {
            private FamilyMember root;

            public FamilyTree(FamilyMember root)
            {
                this.root = root;
            }

            public void DisplayFamilyTree()
            {
                DisplayFamilyTree(root, 0);
            }

            private void DisplayFamilyTree(FamilyMember member, int depth)
            {
                string indentation = new string('-', depth * 2);
                Console.WriteLine($"{indentation}{member.Name} (Age: {member.Age})");

                foreach (var child in member.Children)
                {
                    DisplayFamilyTree(child, depth + 1);
                }
            }
        }
    
}
