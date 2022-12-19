import React from 'react'
import LeftImage from '../Images/Left-girl.svg'
import RightImage from '../Images/RIght-boy.svg'


const Showcase_1 = () => {
  return (
    <showcase1 className='showcase'>
        <div className="container-fluid">
        <img src={LeftImage} alt="" />
            <div className='middle'>
                <h1 className='sale'>SALE UP <br></br>To 50% Off  </h1> 
                <p className='free'>Online shopping free home delivery over $100</p>
                <button className='shop-btn'>SHOP NOW</button>
            </div>
        <img src={RightImage} alt="" />
        </div>
</showcase1>

  )
}

export default Showcase_1