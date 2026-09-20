using UnityEngine;

public class MovementScript : MonoBehaviour
{
	public float speed = 10f;

	private CharacterController PFNFIJFPCPJ;

	private void Awake()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void MPKBLEDGKPO()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void FixedUpdate()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Input.GetAxis("Horizontal") * speed;
		zero.z = Input.GetAxis("Vertical") * speed;
		PFNFIJFPCPJ.SimpleMove(zero);
	}

	private void BNFDGGBLLLI()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Input.GetAxis("StartMenu") * speed;
		zero.z = Input.GetAxis("hit2") * speed;
		PFNFIJFPCPJ.SimpleMove(zero);
	}

	private void DEFLIOMCCMA()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void PCFCEAOOAEE()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void CFJKHPNIODE()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void BFHAELONDKG()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Input.GetAxis("코인") * speed;
		zero.z = Input.GetAxis("FFFFFF") * speed;
		PFNFIJFPCPJ.SimpleMove(zero);
	}

	private void FPFNIFKNOIF()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void DGIKBFFMIJM()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Input.GetAxis("망자의 갑옷") * speed;
		zero.z = Input.GetAxis("No camera found for layer ") * speed;
		PFNFIJFPCPJ.SimpleMove(zero);
	}

	private void NGNNLLLBGMB()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void LHAOAIGACNK()
	{
		Vector3 zero = Vector3.zero;
		zero.x = Input.GetAxis("VND") * speed;
		zero.z = Input.GetAxis("skill0_1") * speed;
		PFNFIJFPCPJ.SimpleMove(zero);
	}

	private void GONLJAHAEBB()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}

	private void PDEKJHLCJHM()
	{
		PFNFIJFPCPJ = GetComponent<CharacterController>();
	}
}
