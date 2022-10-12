using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneServiceApplication
{
    public class Drone
    {
        private string name;
        private string model;
        private string problem;
        private double cost;
        private int tag;

        public Drone()//defult constructor
        {

        }

        public void display(string name, double cost)//display method
        {

        }
        //setters and getters for class attributes 
        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetModel()
        {
            return model;
        }
        public void SetModel(string newModel)
        {
            model = newModel;
        }

        public string GetProblem()
        {
            return problem;
        }
        public void SetProblem(string newProblem)
        {
            problem = newProblem;
        }

        public double GetCost()
        {
            return cost;
        }
        public void SetCost(double newCost)
        {
            cost = newCost;
        }

        public int GetTag()
        {
            return tag;
        }
        public void SetTag(int newTag)
        {
            tag = newTag;
        }
    }
}
