import React from 'react'

const Form = () => {
  return (
    <div className='form container'>
    <div className='contact'>Come in Contact with Us</div>
        <div className='d-flex mt-4 mb-4'>
            <input className='name' type="text" name="name" placeholder='Your Name' />
            <input className='mail' type="text" name="name" placeholder='Your Mail'/>
        </div>
    <textarea name="" id="" cols="30" rows="10" placeholder='Comments'></textarea>
   <button className='buttonsubmit'>Post Comments</button>
</div>
  )
}

export default Form