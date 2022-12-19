import React, {useContext} from 'react'
import Navbar from '../Components/Navbar'
import Showcase_1 from '../Components/Showcase_1'
import Showcase_2 from '../Components/Showcase_2'
import Showcase_3 from '../Components/Showcase_3'
import Showcase_4 from '../Components/Showcase_4'
import Showcase_5 from '../Components/Showcase_5'
import Showcase_6 from '../Components/Showcase_6'
import Footer from '../Components/Footer'

const HomeView = () => {
   
  return (
    <>
    
    <Navbar />
        <Showcase_1 />
        <Showcase_2 />
        <Showcase_3 />
        <Showcase_4 />
        <Showcase_5 />
        <Showcase_6 />
        <Footer />

    </>
  )
}

export default HomeView