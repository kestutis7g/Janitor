using Janitor_V1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Janitor_V1.Utils
{
    internal class Calculations
    {
        private List<Node> Data { get; set; }
        private List<Node> PartsData { get; set; }

        public double rootChildNodeAssemblyDuration = 0;
        public int totalParts = 0;
        public double totalPartsCost = 0;
        public double toolboxWeight = 0;

        public Calculations()
        {
            
        }

        public void Calculate(List<Node> data, List<Node> partsData)
        {
            this.Data = data;
            this.PartsData = partsData;

            refreshRootChildNodeAssemblyDuration();
            refreshTotalParts();
            refreshTotalPartsCost();
            refreshToolboxWeight();
        }
        private void refreshRootChildNodeAssemblyDuration()
        {
            double assemblyDuration = 0;
            foreach (var item in this.Data)
            {
                assemblyDuration += (double)item.Assembly.CombinedAssemblyTime;
            }
            this.rootChildNodeAssemblyDuration = assemblyDuration;
        }

        private void refreshTotalParts()
        {
            this.totalParts = PartsData.Count();
        }
        private void refreshTotalPartsCost()
        {
            double cost = 0;
            foreach (var part in this.PartsData)
            {
                cost += part.Part.Price ?? default(int);
            }
            this.totalPartsCost = cost;
        }
        private void refreshToolboxWeight()
        {
            double weight = 0;
            foreach (var part in this.PartsData)
            {
                if(part.Part.PartType == PartType.Toolbox)
                {
                    weight += part.Part.Weight ?? default;
                }
            }
            this.toolboxWeight = weight;
        }
    }
}
