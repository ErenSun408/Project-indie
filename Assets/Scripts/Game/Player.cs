using UnityEngine;
using QFramework;
using UnityEngine.Tilemaps;
using Unity.VisualScripting;

namespace ProjectIndie
{
	public partial class Player : ViewController
	{
		public Grid Grid;
		public Tilemap Tilemap;


		void Start()
		{
			// Code Here
		}


		private void Update()
		{
			if (Input.GetMouseButtonDown(0))
			{
				//指定位置生成
				var cellPosition = Grid.WorldToCell(transform.position);
				// Tilemap.SetTile(cellPosition, null);
				var grid = FindFirstObjectByType<GridController>().ShowGrid;

				if (cellPosition.x<10 && cellPosition.x>=0 && cellPosition.y<10 && cellPosition.y>=0)
				{
					//指定位置若没有则生成
					if (grid[cellPosition.x, cellPosition.y] == null)
					{
						Tilemap.SetTile(cellPosition, FindFirstObjectByType<GridController>().Pen);
						grid[cellPosition.x, cellPosition.y] = new SoilData();
					}
				}
				


				// var tile = Tilemap.GetTile(cellPosition);
				// transform.position.x/y 拿到x，y值
				// 根据x，y值，拿到tilemap的具体块
				// 拿到具体块消除
			}

		}
	}
}
