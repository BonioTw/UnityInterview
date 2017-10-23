using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseModal : MonoBehaviour {
  public Text txtTotalAmount;
  public Button btnIncrease;
  public Button btnDecrease;
  protected int totalAmount = 0;
  protected int totalPrice = 0;
  protected int unitPrice = 0;
  protected int maxCount = 0;

  public virtual void Init(){
    totalAmount = 0;
    totalPrice = 0;
    unitPrice = 0;
    maxCount = 0;
  }

  public virtual void IncreaseAmount(){
    totalAmount += 1;
    if(totalAmount > maxCount)
      totalAmount = maxCount;
    totalPrice = txtTotalAmount * unitPrice;
    txtTotalAmount.text = totalPrice.ToString();
  }

  public virtual void IncreaseAmount(){
    totalAmount -= 1;
    if(totalAmount < 0)
      totalAmount = 0;
    totalPrice = txtTotalAmount * unitPrice;
    txtTotalAmount.text = totalPrice.ToString();
  }

  public virtual void Close(){
    //todo
    //close this modal
  }

}
