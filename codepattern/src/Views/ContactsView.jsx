import React from 'react'
import { NavLink } from 'react-router-dom'
import MenuIcon from '../Components/MenuIcon'
import Navbar from '../Components/Navbar'
import Footer from '../Components/Footer'
import Map from '../Components/Map'
import Form from '../Components/Form'

const ContactsView = () => {
  return (

    <div>
          <Navbar />
          
{/* 
<section className='breadcrumb'>
        <div className='container'>
            <ul className='breadcrumb-list'>
            <li>
                <NavLink to="/" className="me-1">Home</NavLink>
            </li>
             <li>{ContactsView}</li>
            </ul>
        </div>
</section> */}

<Map />
<Form />
<Footer />


    </div>
   )
}

export default ContactsView