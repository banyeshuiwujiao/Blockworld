using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script
{
    class Tree : MonoBehaviour
    {
        private readonly GameObject[] blocks;

        public Tree(GameObject[] blocks)
        {
            this.blocks = blocks;
        }

        /// <summary>
        /// Place the second layer of leaves (starting from the top) to a tree.
        /// </summary>
        /// <param name="pos">position of the second layer wood log of the tree</param>
        /// <returns>array of objects not placed in the enviroment yet</returns>
        public GameObject[] CreateLeavesLayer2(Vector3 pos)
        {
            GameObject leavesBlock1 = Instantiate(blocks[4], new Vector3(pos.x + 1, pos.y, pos.z), Quaternion.identity);
            GameObject leavesBlock2 = Instantiate(blocks[4], new Vector3(pos.x - 1, pos.y, pos.z), Quaternion.identity);
            GameObject leavesBlock3 = Instantiate(blocks[4], new Vector3(pos.x, pos.y, pos.z + 1), Quaternion.identity);
            GameObject leavesBlock4 = Instantiate(blocks[4], new Vector3(pos.x, pos.y, pos.z - 1), Quaternion.identity);
            return new GameObject[] { leavesBlock1, leavesBlock2, leavesBlock3, leavesBlock4 };
        }
    }
}
