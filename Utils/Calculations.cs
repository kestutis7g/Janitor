﻿using Janitor_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Janitor_V1.Utils
{
    public class Calculations
    {
        //įrenginio įvairūs skaičiavimai
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

        public double CountTotalWeldingDuration(List<Node> data)
        {
            //suskaičiuojamas bendras virinimo laikas
            double totalWeldingDuration = 0;
            foreach(Node node in data) 
            {
                if(node.ComponentType == NodeType.Part)
                {
                    continue;
                }

                totalWeldingDuration += (double)node.Assembly.WeldingDuration;
                if (node.Children.Count > 0)
                {
                    totalWeldingDuration += CountTotalWeldingDuration(node.Children);
                }
            }

            return totalWeldingDuration;
        }

        private void refreshRootChildNodeAssemblyDuration()
        {
            //įrenginio vaikų surinkimo laikas
            double assemblyDuration = 0;
            foreach (var item in this.Data)
            {
                assemblyDuration += (double)item.Assembly.CombinedAssemblyTime;
            }
            this.rootChildNodeAssemblyDuration = assemblyDuration;
        }

        private void refreshTotalParts()
        {
            //atnaujina detalių skaičių
            this.totalParts = 0;
            foreach (var part in PartsData)
            {
                this.totalParts += part.DuplicateAmount;
            }

        }
        private void refreshTotalPartsCost()
        {
            //detalių bendra kaina
            double cost = 0;
            foreach (var part in this.PartsData)
            {
                cost += (part.Part.Price ?? 0) * part.DuplicateAmount;
            }
            this.totalPartsCost = Math.Round(cost,2);
        }
        private void refreshToolboxWeight()
        {
            //susumuoja Toolbox komponentų svorį
            double weight = 0;
            foreach (var part in this.PartsData)
            {
                if(part.Part.PartType == PartType.Toolbox)
                {
                    weight += (part.Part.Weight ?? 0) * part.DuplicateAmount;
                }
            }
            this.toolboxWeight = weight;
        }
    }
}
