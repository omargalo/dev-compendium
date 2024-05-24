Default web font size 16px

Global page size = 1280

Add Stylesheets

html {
  font-size: 62.5%;
}

https://websemantics.uk/tools/responsive-font-calculator/

unit: rem
selecto: div
property: h1
range: 3.2 to 4.8
viewport: 32 to 128

## clamp
h1: 3.2, 4.8 clamp(3.2rem, calc(3.2rem + ((1vw - 0.32rem) * 1.6667)), 4.8rem)
h2: 2.8, 3.8 clamp(2.8rem, calc(2.8rem + ((1vw - 0.32rem) * 1.0417)), 3.8rem)
h3: 2.4, 3.2 clamp(2.4rem, calc(2.4rem + ((1vw - 0.32rem) * 0.8333)), 3.2rem)
h4: 2.2, 2.8 clamp(2.2rem, calc(2.2rem + ((1vw - 0.32rem) * 0.625)), 2.8rem)
h5: 2.0, 2.2 clamp(2rem, calc(2rem + ((1vw - 0.32rem) * 0.2083)), 2.2rem)
h6: 1.4, 1.8 clamp(1.4rem, calc(1.4rem + ((1vw - 0.32rem) * 0.4167)), 1.8rem)
text: clamp(1.8rem, calc(1.8rem + ((1vw - 0.32rem) * 0.2083)), 2rem)
Line height: 1.3

## Global styles

Sections and columns->
Section container padding: clamp top and bottom 7, 12 -> left: 3rem right: 3rem
	clamp(7rem, calc(7rem + ((1vw - 0.32rem) * 5.2083)), 12rem)
columns padding: none
Smooth scroll on hash links: 500ms
