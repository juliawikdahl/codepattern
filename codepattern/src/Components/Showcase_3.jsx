import React from 'react'
import PamelaSecond from '../Images/Pamela_2.svg'
import PamelaImage from '../Images/Pamela.svg'
const Showcase_3 = () => {
  return (
    <showcase3 className='boxes'>
    <div className='box-left'>
        <img className="pamela" src={PamelaImage} alt="" />
        <h1>Pamela Reif's <br></br>Top Picks</h1>
        <button className='shopnow-btn'>SHOP NOW</button>

    </div>

    <div className='box-right'>
        <h1>Let's Be <br /> Conscious</h1>
        <img className="Pamela2" src={PamelaSecond} alt="" />
        <button className='shopnow-btn2'>FLASH SALE</button>

    </div>

</showcase3>

  )
}

export default Showcase_3