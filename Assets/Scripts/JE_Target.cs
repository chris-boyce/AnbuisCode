
using UnityEngine;

public class JE_Target : MonoBehaviour
{
	public float health = 50f;

	public void TakeDamage (float amount)
	{
		health -= amount;
		if (health <= 0f)
		{
			Die();
		}
	}
	//--------------------------------

	void Die ()
	{
		Destroy(gameObject);
	}
	//----------------------------
}
