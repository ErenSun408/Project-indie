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
			if (Input.GetKeyDown(KeyCode.J))
			{
				var cellPosition = Grid.WorldToCell(transform.position);
				// var tile = Tilemap.GetTile(cellPosition);
				Tilemap.SetTile(cellPosition, null);


				// transform.position.x/y 拿到x，y值
				// 根据x，y值，拿到tilemap的具体块
				// 拿到具体块消除
			}

		}
	}
}
