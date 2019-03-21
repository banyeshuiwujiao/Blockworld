using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script
{
    class TreeSpawn : MonoBehaviour
    {

        /// <summary>
        /// Place the first layer of leaves (starting from the top) to a tree. 
        /// </summary>
        /// <param name="blocks">array of template blocks</param>
        /// <param name="pos">>position of the first layer WOOD LOG of the tree</param>
        /// <returns>the top leaves block of a tree without parent</returns>
        public static GameObject CreateLeavesLayer1(GameObject[] blocks, Vector3 pos)
        {
            GameObject leavesBlock = Instantiate(blocks[4], new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
            return leavesBlock;
        }

        /// <summary>
        /// Place the second layer of leaves (starting from the top) to a tree.
        /// </summary>
        /// <param name="blocks">array of template blocks</param>
        /// <param name="pos">position of the second layer WOOD LOG of the tree</param>
        /// <returns>array of GameObjects without parent</returns>
        public static GameObject[] CreateLeavesLayer2(GameObject[] blocks, Vector3 pos)
        {
            GameObject leavesBlock1 = Instantiate(blocks[4], new Vector3(pos.x + 1, pos.y, pos.z), Quaternion.identity);
            GameObject leavesBlock2 = Instantiate(blocks[4], new Vector3(pos.x - 1, pos.y, pos.z), Quaternion.identity);
            GameObject leavesBlock3 = Instantiate(blocks[4], new Vector3(pos.x, pos.y, pos.z + 1), Quaternion.identity);
            GameObject leavesBlock4 = Instantiate(blocks[4], new Vector3(pos.x, pos.y, pos.z - 1), Quaternion.identity);
            return new GameObject[] { leavesBlock1, leavesBlock2, leavesBlock3, leavesBlock4 };
        }

        /// <summary>
        /// Place the third layer of leaves (starting from the top) to a tree.
        /// </summary>
        /// <param name="blocks">array of template blocks</param>
        /// <param name="pos">position of the third layer WOOD LOG of the tree</param>
        /// <returns>array of GameObjects without parent</returns>
        public static GameObject[] CreateLeavesLayer3(GameObject[] blocks, Vector3 pos)
        {
            GameObject leavesBlock1 = Instantiate(blocks[4], new Vector3(pos.x + 1, pos.y, pos.z), Quaternion.identity);
            GameObject leavesBlock2 = Instantiate(blocks[4], new Vector3(pos.x - 1, pos.y, pos.z), Quaternion.identity);
            GameObject leavesBlock3 = Instantiate(blocks[4], new Vector3(pos.x, pos.y, pos.z + 1), Quaternion.identity);
            GameObject leavesBlock4 = Instantiate(blocks[4], new Vector3(pos.x, pos.y, pos.z - 1), Quaternion.identity);
            GameObject leavesBlock5 = Instantiate(blocks[4], new Vector3(pos.x + 1, pos.y, pos.z + 1), Quaternion.identity);
            GameObject leavesBlock6 = Instantiate(blocks[4], new Vector3(pos.x + 1, pos.y, pos.z - 1), Quaternion.identity);
            GameObject leavesBlock7 = Instantiate(blocks[4], new Vector3(pos.x - 1, pos.y, pos.z + 1), Quaternion.identity);
            GameObject leavesBlock8 = Instantiate(blocks[4], new Vector3(pos.x - 1, pos.y, pos.z - 1), Quaternion.identity);
            return new GameObject[] { leavesBlock1, leavesBlock2, leavesBlock3, leavesBlock4, leavesBlock5, leavesBlock6, leavesBlock7, leavesBlock8 };
        }
    }
}
