using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using static LearnEnglishWords.TheGame;

namespace LearnEnglishWords
{

    public static class Extensions
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            Random rnd = new Random();
            return source.OrderBy((item) => rnd.Next());
        }
    }

    public class WordDatabase
    {
        public static string TheClimb = @"I can almost see it
That dream I'm dreaming
But, there's a voice inside my head saying
You'll never reach it
Every step I'm taking
Every move I make feels
Lost with no direction
My faith is shaking
But I, I gotta keep trying
Gotta keep my head held high
There's always gonna be another mountain
I'm always gonna wanna make it move
Always gonna be an uphill battle
Sometimes I'm gonna have to lose
Ain't about how fast I get there
Ain't about what's waiting on the other side
It's the climb
The struggles I'm facing
The chances I'm taking
Sometimes might knock me down, but
No, I'm not breaking
I may not know it
But these are the moments, that
I'm gonna remember most, yeah
Just gotta keep going
And I, I gotta be strong
Just keep pushing on, 'cause
There's always gonna be another mountain
I'm always gonna wanna make it move
Always gonna be an uphill battle
Sometimes I'm gonna have to lose
Ain't about how fast I get there
Ain't about what's waiting on the other side
It's the climb
Yeah
There's always gonna be another mountain
I'm always gonna wanna make it move
Always gonna be an uphill battle
Sometimes you're gonna have to lose
Ain't about how fast I get there
Ain't about what's waiting on the other side
It's the climb
Yeah, yeah
Keep on moving, keep climbing
Keep the faith, baby
It's all about, it's all about the climb
Keep your faith, keep your faith
Whoa";

        public static string MrJones = @"I was down at the New Amsterdam
Staring at this yellow-haired girl
Mr. Jones strikes up a conversation
With a black-haired flamenco dancer
You know she dances while his father plays guitar
She's suddenly beautiful
And we all want something beautiful
Man, I wish I was beautiful
So come dance the silence down through the morning
Sha-la-la-la-la-la-la, yeah
Uh huh, yeah
Cut up, Maria
Show me some of them Spanish dances
Pass me a bottle, Mr. Jones
Believe in me
Help me believe in anything
'Cause I wanna be someone who believes
Yeah
Mr. Jones and me
Tell each other fairy tales
And we stare at the beautiful women
She's looking at you
Ah, no, no, she's looking at me
Smilin' in the bright lights
Coming through in stereo
When everybody loves you
You can never be lonely
Well, I'm gon' paint my picture
Paint myself in blue and red and black and gray
All of the beautiful colors are very, very meaningful
Yeah, well, you know gray is my favorite color
I felt so symbolic yesterday
If I knew Picasso
I would buy myself a gray guitar and play
Mr. Jones and me
Looked into the future
Yeah, we stare at the beautiful women
She's looking at you
I don't think so
She's looking at me
Standing in the spotlight
I bought myself a gray guitar
When everybody loves me
I will never be lonely
I will never be lonely
Said I'm never gonna be lonely
I wanna be a lion
Yeah, everybody wanna pass as cats
We all wanna be big, big stars
Yeah, but we got different reasons for that
Believe in me
'Cause I don't believe in anything
And I wanna be someone to believe, to believe, to believe
Yeah
Mr. Jones and me
Stumbling through the barrio
Yeah, we stare at the beautiful women
She's perfect for you
Man, there's got to be somebody for me
I wanna be Bob Dylan
Mr. Jones wishes he was someone just a little more funky
When everybody loves you, ah son
That's just about as funky as you can be
Mr. Jones and me
Staring at the video
When I look at the television, I want to see me
Staring right back at me
We all wanna be big stars
But we don't know why, and we don't know how
But when everybody loves me
I'm wanna be just about as happy as I can be
Mr. Jones and me
We're gonna be big stars";


        public static string EndOfWorld = @"That's great, it starts with an earthquake
Birds and snakes, and aeroplanes
And Lenny Bruce is not afraid
Eye of a hurricane, listen to yourself churn
World serves its own needs
Don't mis-serve your own needs
Speed it up a notch, speed, grunt, no, strength
The ladder starts to clatter
With a fear of height, down, height
Wire in a fire, represent the seven games
And a government for hire and a combat site
Left her, wasn't coming in a hurry
With the Furies breathing down your neck
Team by team, reporters baffled, trumped, tethered, cropped
Look at that low plane, fine, then
Uh oh, overflow, population, common group
But it'll do, save yourself, serve yourself
World serves its own needs, listen to your heart bleed
Tell me with the Rapture and the reverent in the right, right
You vitriolic, patriotic, slam fight, bright light
Feeling pretty psyched
It's the end of the world as we know it
It's the end of the world as we know it
It's the end of the world as we know it and I feel fine
Six o'clock, T.V. hour, don't get caught in foreign tower
Slash and burn, return, listen to yourself churn
Lock him in uniform, book burning, bloodletting
Every motive escalate, automotive incinerate
Light a candle, light a motive, step down, step down
Watch your heel crush, crush, uh oh
This means no fear, cavalier, renegade and steering clear
A tournament, a tournament, a tournament of lies
Offer me solutions, offer me alternatives and I decline
It's the end of the world as we know it (I had some time alone)
It's the end of the world as we know it (I had some time alone)
It's the end of the world as we know it and I feel fine (time I had some time alone)
I feel fine (I feel fine)
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it and I feel fine (time I had some time alone)
The other night I drifted nice continental drift divide
Mountains sit in a line, Leonard Bernstein
Leonid Brezhnev, Lenny Bruce and Lester Bangs
Birthday party, cheesecake, jellybean, boom
You symbiotic, patriotic, slam but neck, right, right
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it and I feel fine (time I had some time alone)
It's the end of the world as we know it
It's the end of the world as we know it
It's the end of the world as we know it and I feel fine (time I had some time alone)
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it and I feel fine (time I had some time alone)
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it (time I had some time alone)
It's the end of the world as we know it and I feel fine (time I had some time alone)";


        public static string TheReasonHoobastank = @"I'm not a perfect person
There's many things I wish I didn't do
But I continue learning
I never meant to do those things to you
And so, I have to say before I go
That I just want you to know
I've found a reason for me
To change who I used to be
A reason to start over new
And the reason is you
I'm sorry that I hurt you
It's something I must live with everyday
And all the pain I put you through
I wish that I could take it all away
And be the one who catches all your tears
That's why I need you to hear
I've found a reason for me
To change who I used to be
A reason to start over new
And the reason is you
And the reason is you
And the reason is you
And the reason is you
I'm not a perfect person
I never meant to do those things to you
And so I have to say before I go
That I just want you to know
I've found a reason for me
To change who I used to be
A reason to start over new
And the reason is you
I've found a reason to show
A side of me you didn't know
A reason for all that I do
And the reason is you";

        public static string WhitneyIHaveNothing = @"Share my life
Take me for what I am
'Cause I'll never change
All my colors for you
Take my love
I'll never ask for too much
Just all that you are
And everything that you do
I don't really need to look
Very much further
I don't want to have to go
Where you don't follow
I will hold it back again
This passion inside
Can't run from myself
There's nowhere to hide
Don't make me close one more door
I don't want to hurt anymore
Stay in my arms if you dare
Or must I imagine you there
Don't walk away from me
I have nothing, nothing, nothing
If I don't have you, you, you, you, you
You see through
Right to the heart of me
You break down my walls
With the strength of your love, hm
I never knew
Love like I've known it with you
Will a memory survive
One I can hold on to
I don't really need to look
Very much further
I don't want to have to go
Where you don't follow
I will hold it back again
This passion inside
I can't run from myself
There's nowhere to hide
Your love I'll remember forever
Don't make me close one more door
I don't want to hurt anymore
Stay in my arms if you dare
Or must I imagine you there
Don't walk away from me
I have nothing, nothing, nothing
Don't make me close one more door
I don't want to hurt anymore
Stay in my arms if you dare
Or must I imagine you there
Don't walk away from me
No, don't walk away from me
Don't you dare walk away from me
I have nothing, nothing, nothing
If I don't have you, you
If I don't have you, oh you
";

        public static string Marron5Memories = @"Here's to the ones that we got
Cheers to the wish you were here, but you're not
'Cause the drinks bring back all the memories
Of everything we've been through
Toast to the ones here today
Toast to the ones that we lost on the way
'Cause the drinks bring back all the memories
And the memories bring back, memories bring back you
There's a time that I remember, when I did not know no pain
When I believed in forever, and everything would stay the same
Now my heart feel like December when somebody say your name
'Cause I can't reach out to call you, but I know I will one day, yeah
Everybody hurts sometimes
Everybody hurts someday, ayy ayy
But everything gon' be alright
Go and raise a glass and say, ayy
Here's to the ones that we got
Cheers to the wish you were here, but you're not
'Cause the drinks bring back all the memories
Of everything we've been through
Toast to the ones here today
Toast to the ones that we lost on the way
'Cause the drinks bring back all the memories
And the memories bring back, memories bring back you
Doo doo, doo doo doo doo
Doo doo doo doo, doo doo doo doo
Doo doo doo doo, doo doo doo
Memories bring back, memories bring back you
There's a time that I remember when I never felt so lost
When I felt all of the hatred was too powerful to stop (ooh, yeah)
Now my heart feel like an ember and it's lighting up the dark
I'll carry these torches for ya that you know I'll never drop, yeah
Everybody hurts sometimes
Everybody hurts someday, ayy ayy
But everything gon' be alright
Go and raise a glass and say, ayy
Here's to the ones that we got (oh)
Cheers to the wish you were here, but you're not
'Cause the drinks bring back all the memories
Of everything we've been through (no, no)
Toast to the ones here today (ayy)
Toast to the ones that we lost on the way
'Cause the drinks bring back all the memories (ayy)
And the memories bring back, memories bring back you
Doo doo, doo doo doo doo
Doo doo doo doo, doo doo doo doo
Doo doo doo doo, doo doo doo
Memories bring back, memories bring back you
Doo doo, doo doo doo doo
Doo doo doo doo, doo doo doo doo
Doo doo doo doo, doo doo doo (ooh, yeah)
Memories bring back, memories bring back you
Yeah, yeah, yeah
Yeah, yeah, yeah, yeah, yeah, doh, doh
Memories bring back, memories bring back you";
        public static string Aerosmith_IDontWantToMissAThing = @"I could stay awake just to hear you breathing
Watch you smile while you are sleeping
While you're far away and dreaming
I could spend my life in this sweet surrender
I could stay lost in this moment forever
Every moment spent with you is a moment I treasure
Don't want to close my eyes
I don't want to fall asleep
'Cause I'd miss you baby
And I don't want to miss a thing
'Cause even when I dream of you
The sweetest dream will never do
I'd still miss you baby
And I don't want to miss a thing
Lying close to you, feeling your heart beating
And I'm wondering what you're dreaming
Wondering if it's me you're seeing
Then I kiss your eyes
And thank God we're together
And I just want to stay with you in this moment forever
Forever and ever
I don't want to close my eyes
I don't want to fall asleep
'Cause I'd miss you baby
And I don't want to miss a thing
'Cause even when I dream of you
The sweetest dream will never do
I'd still miss you baby
And I don't want to miss a thing
I don't want to miss one smile
And I don't want to miss one kiss
And I just want to be with you
Right here with you, just like this
And I just want to hold you close
I feel your heart so close to mine
And just stay here in this moment
For all the rest of time
Yeah, yeah, yeah, yeah, yeah
Don't want to close my eyes
Don't want to fall asleep
'Cause I'd miss you baby
And I don't want to miss a thing
'Cause even when I dream of you (even when I dream)
The sweetest dream will never do
I'd still miss you baby
And I don't want to miss a thing
I don't want to close my eyes
I don't want to fall asleep
'Cause I'd miss you baby
And I don't want to miss a thing
'Cause even when I dream of you
The sweetest dream will never do
I'd still miss you baby
And I don't want to miss a thing
Don't want to close my eyes
I don't want to fall asleep, yeah
And I don't want to miss a thing";

        public static string SheLovesYouTheBeatles = @"She loves you, yeah, yeah, yeah
She loves you, yeah, yeah, yeah
She loves you, yeah, yeah, yeah, yeah

You think you lost your love
Well, I saw her yesterday
It's you she's thinking of
And she told me what to say

She says she loves you
And you know that can't be bad
Yes, she loves you
And you know you should be glad

She said you hurt her so
She almost lost her mind
But now she says she knows
You're not the hurting kind

She says she loves you
And you know that can't be bad
Yes, she loves you
And you know you should be glad, ooh

She loves you, yeah, yeah, yeah
She loves you, yeah, yeah, yeah
And with a love like that
You know you should be glad

You know it's up to you
I think it's only fair
Pride can hurt you too
Apologize to her

Because she loves you
And you know that can't be bad
Yes, she loves you
And you know you should be glad, ooh

She loves you, yeah, yeah, yeah
She loves you, yeah, yeah, yeah
With a love like that
You know you should be glad
With a love like that
You know you should be glad
With a love like that
You know you should be glad
Yeah, yeah, yeah
Yeah, yeah, yeah, yeah";
      public static string RayMillencolin = @"Hey, what the hell do you want me to do?
Hey, does it look like I'm static to you?
You might look twice, 'cause I'm moving
Ok, you see that I can walk which is good
But still you're trying to make me talk like you would
Your intention's nice, you're improving
For all you know, you are doing fine
But I guess it shows
That even jewellery that's fake do shine
So shut your mouth now big boy
I'm just myself not your toy
It's in my nature to be changing
Now is it so hard to see?
You cannot make me to be
Someone who never will be changing
So what the hell do you want me to say?
Another halting rhyme, another cliche?
Well, you might be right, for this one time
You take for granted, I'm your servant subdued
It doesn't make sense to me but to you
So here's one last bright make shift rhyme
For all you know
I'm just a fool
But I guess that shows
You can't judge a dog just by it's drool
So shut your mouth now big boy
I'm just myself not your toy
It's in my nature to be changing
Now is it so hard to see?
You cannot make me to be
Someone who never will be changing
I'm losing you, for a big smile on my face
You're nothing new, not hard to replace
I'm losing you, but I'm not losing ground
So Peekaboo! And you won't be around
You won't be around
You won't be around
So shut your mouth now big boy
I'm just myself not your toy
It's in my nature to be changing
Now is it so hard to see?
You cannot make me to be
Someone who never will be changing
'Cause I change with time
And that's not a crime
Someone like you cannot derange me
I change with time
That's not a crime
It's in my nature to be changing
Changing";
        public static string OneU2 = @"Is it getting better?
Or do you feel the same?
Will it make it easier on you now?
You got someone to blame
You say, one love, one life
When it's one need in the night
One love, we get to share it
Leaves you baby if you don't care for it
Did I disappoint you?
Or leave a bad taste in your mouth?
You act like you never had love
And you want me to go without
Well it's too late tonight
To drag the past out into the light
We're one but we're not the same
We get to carry each other, carry each other
One!
Have you come here for forgiveness?
Have you come to raise the dead?
Have you come here to play Jesus?
To the lepers in your head
Did I ask too much? More than a lot
You gave me nothin' now it's all I got
We're one but we're not the same
Well we hurt each other then we do it again
You say love is a temple, love a higher law
Love is a temple, love the higher law
You ask me to enter but then you make me crawl
And I can't be holdin' on to what you got
When all you got is hurt
One love, one blood
One life, you got to do what you should
One life, with each other
Sisters, brothers
One life but we're not the same
We get to carry each other, carry each other
One
One";

        public static string SayYouWontLetGoJamesArthur = @"
I met you in the dark, you lit me up
You made me feel as though I was enough
We danced the night away, we drank too much
I held your hair back when
You were throwing up
Then you smiled over your shoulder
For a minute, I was stone-cold sober
I pulled you closer to my chest
And you asked me to stay over
I said, I already told ya
I think that you should get some rest
I knew I loved you then
But you'd never know
'Cause I played it cool when I was scared of letting go
I know I needed you
But I never showed
But I wanna stay with you until we're grey and old
Just say you won't let go
Just say you won't let go
I'll wake you up with some breakfast in bed
I'll bring you coffee with a kiss on your head
And I'll take the kids to school
Wave them goodbye
And I'll thank my lucky stars for that night
When you looked over your shoulder
For a minute, I forget that I'm older
I wanna dance with you right now
Oh, and you look as beautiful as ever
And I swear that everyday you'll get better
You make me feel this way somehow
I'm so in love with you
And I hope you know
Darling, your love is more than worth its weight in gold
We've come so far, my dear
Look how we've grown
And I wanna stay with you until we're grey and old
Just say you won't let go
Just say you won't let go
I wanna live with you
Even when we're ghosts
'Cause you were always there for me when I needed you most
I'm gonna love you 'til
My lungs give out
I promise 'til death we part like in our vows
So I wrote this song for you, now everybody knows
That it's just you and me 'til we're grey and old
Just say you won't let go
Just say you won't let go
Just say you won't let go
Oh, just say you won't let go";
        public static string OthersideRedHot = @"How long, how long will I slide?
Separate my side, I don't
I don't believe it's bad
Slit my throat it's all I ever
I heard your voice through a photograph
I thought it up and brought up the past
Once you know you can never go back
I gotta take it on the other side
Centuries are what it meant to me
A cemetery where I marry the sea
Stranger things could never change my mind
I gotta take it on the other side
Take it on the other side
Take it on, take it on
How long, how long will I slide?
Separate my side, I don't
I don't believe it's bad
Slit my throat it's all I ever
Pour my life into a paper cup
The ashtray's full and I'm spillin' my guts
She wants to know, am I still a slut?
I've got to take it on the other side
A scarlet starlet and she's in my bed
A candidate for a soul mate bled
Push the trigger and pull the thread
I gotta take it on the other side
Take it on the other side
Take it on
Take it on
How long, how long will I slide?
Separate my side, I don't
I don't believe it's bad
Slit my throat it's all I ever
Turn me on, take me for a hard ride
Burn me out, leave me on the other side
I yell and tell it that it's not my friend
I tear it down, I tear it down
And then it's born again
How long, how long will I slide?
Separate my side, I don't
I don't believe it's bad
Slit my throat it's all I ever
How long, I don't, I don't believe it's bad
Slit my throat it's all I ever";

        public static string ArianaDangerousWoman = @"Oh, yeah
Don't need permission
Made my decision to test my limits
'Cause it's my business
God as my witness
Start what I finished
Don't need no hold up
Taking control of this kind of moment
I'm locked and loaded
Completely focused my mind is open
All that you got, skin to skin, oh my God
Don't you stop, boy
Somethin' 'bout you
Makes me feel like a dangerous woman
Somethin' 'bout, somethin' 'bout
Somethin' 'bout you
Makes me wanna do things that I shouldn't
Somethin' 'bout, somethin' 'bout, somethin' 'bout
Nothin' to prove and I'm bulletproof and
Know what I'm doing
The way we're movin' like introducing
Us to a new thing
I wanna savor, save it for later
The taste of flavor, 'cause I'm a taker
'Cause I'm a giver, it's only nature
I live for danger
All that you got, skin to skin, oh my God
Don't you stop, boy
Oh, yeah
Somethin' 'bout you
Makes me feel like a dangerous woman
Somethin' 'bout, somethin' 'bout
Somethin' 'bout you
Makes me wanna do things that I shouldn't
Somethin' 'bout, somethin' 'bout
Somethin' 'bout you
All girls wanna be like that
Bad girls underneath, like that
You know how I'm feeling inside (somethin' 'bout, somethin' 'bout)
All girls wanna be like that
Bad girls underneath, like that
You know how I'm feeling inside (somethin' 'bout, somethin' 'bout)
Somethin' 'bout you
Makes me feel like a dangerous woman
Somethin' 'bout, somethin' 'bout
Somethin' 'bout you
Makes me wanna do things that I shouldn't
Somethin' 'bout, somethin' 'bout
Somethin' 'bout you
All girls wanna be like that
Bad girls underneath like that
You know how I'm feeling inside
Somethin' 'bout, somethin' 'bout
All girls wanna be like that
Bad girls underneath like that
You know how I'm feeling inside (somethin' 'bout, somethin' 'bout)
somethin' 'bout, somethin' 'bout
Somethin' 'bout you
(Yeah, there's somethin' 'bout you boy)
(Yeah, there's somethin' 'bout you boy)
(Yeah, there's somethin' 'bout you boy) somethin' 'bout, somethin' 'bout
Somethin' 'bout you";

        public static string LoveOfMyLive = @"Love of my life, you've hurt me
You've broken my heart and now you leave me
Love of my life, can't you see?
Bring it back, bring it back
Don't take it away from me, because you don't know
What it means to me
Love of my life, don't leave me
You've stolen my love, you now desert me
Love of my life, can't you see?
Bring it back, bring it back
Don't take it away from me
Because you don't know
What it means to me
Obrigado
You will remember
When this is blown over
Everything's all by the way
When I grow older
I will be there at your side to remind you
How I still love you (I still love you)
I still love you
Oh, hurry back, hurry back
Don't take it away from me
You don't know what it means to me
Love of my life
Love of my life
Ooh, eh (alright)";
        public static string Sunday = @"Yeah
I can't believe the news today
Oh, I can't close my eyes
And make it go away
How long?
How long must we sing this song?
How long, how long?
'Cause tonight, we can be as one
Tonight
Broken bottles under children's feet
Bodies strewn across the dead end street
But I won't heed the battle call
It puts my back up
Puts my back up against the wall
Sunday, Bloody Sunday
Sunday, Bloody Sunday
Sunday, Bloody Sunday, Sunday, Bloody Sunday (alright)
And the battle's just begun
There's many lost, but tell me who has won
The trench is dug within our hearts
And mothers, children, brothers, sisters torn apart
Sunday, Bloody Sunday
Sunday, Bloody Sunday
How long?
How long must we sing this song?
How long, how long?
'Cause tonight, we can be as one
Tonight, tonight
Sunday, Bloody Sunday
(Tonight, tonight) Sunday, Bloody Sunday (let's go)
Wipe the tears from your eyes
Wipe your tears away
Oh, wipe your tears away
I'll, wipe your tears away (Sunday, Bloody Sunday)
I'll, wipe your blood shot eyes (Sunday, Bloody Sunday)
Sunday, Bloody Sunday (Sunday, Bloody Sunday)
Sunday, Bloody Sunday (Sunday, Bloody Sunday)
And it's true we are immune
When fact is fiction and TV reality
And today the millions cry
We eat and drink while tomorrow they die
the real battle just begun
(Sunday, Bloody Sunday) to claim the victory Jesus won
On
Sunday Bloody Sunday, yeah
Sunday Bloody Sunday";

        public static string Complicated = @"Uh huh, life's like this
Uh huh, uh huh, that's the way it is
'Cause life's like this
Uh huh, uh huh, that's the way it is
Chill out, what ya yellin' for?
Lay back, it's all been done before
And if, you could only let it be, you will see
I like you the way you are
When we're driving in your car
And you're talking to me one on one, but you become
Somebody else
'Round everyone else
You're watching your back
Like you can't relax
You try to be cool
You look like a fool to me
Tell me
Why'd you have to go and make things so complicated?
I see the way you're acting like you're somebody else
Gets me frustrated
Life's like this, you
And you fall, and you crawl, and you break
And you take what you get, and you turn it into
Honesty and promise me I'm never gonna find you faking
No, no, no
You come over unannounced
Dressed up like you're somethin' else
Where you are and where it's at you see
You're making me
Laugh out when you strike your pose
Take off all your preppy clothes
You know you're not fooling anyone
When you become
Somebody else
'Round everyone else
You're watching your back
Like you can't relax
You try to be cool
You look like a fool to me
Tell me
Why'd you have to go and make things so complicated?
I see the way you're acting like you're somebody else
Gets me frustrated
Life's like this, you
And you fall, and you crawl, and you break
And you take what you get, and you turn it into
Honesty and promise me I'm never gonna find you faking
No, no, no
No, no, no
No, no, no
No, no, no
No, no, no (no, no)
Chill out, what ya yellin' for?
Lay back, it's all been done before
And if you could only let it be
You will see
Somebody else
'Round everyone else
You're watching your back
Like you can't relax
You try to be cool
You look like a fool to me
Tell me
Why'd you have to go and make things so complicated?
I see the way you're acting like you're somebody else
Gets me frustrated
Life's like this, you
And you fall, and you crawl, and you break
And you take what you get, and you turn it into
Honesty and promise me I'm never gonna find you faking
No, no
Why'd you have to go and make things so complicated?
I see the way you're acting like you're somebody else
Gets me frustrated
Life's like this, you
And you fall, and you crawl, and you break
And you take what you get, and you turn it into
Honesty and promise me I'm never gonna find you faking
No, no, no";

        public static string Help = @"I need somebody
(Help!) not just anybody
(Help!) you know I need someone
Help!
I never needed anybody's help in any way
But now these days are gone, I'm not so self assured (but now these days are gone)
(And now I find) Now I find I've changed my mind and opened up the doors
Help me if you can, I'm feeling down
And I do appreciate you being 'round
Help me get my feet back on the ground
Won't you please, please help me?
And now my life has changed in oh so many ways (and now my life has changed)
My independence seems to vanish in the haze
But every now and then I feel so insecure (I know that I)
I know that I just need you like I've never done before
Help me if you can, I'm feeling down
And I do appreciate you being 'round
Help me get my feet back on the ground
Won't you please, please help me
When I was younger, so much younger than today
I never needed anybody's help in any way
But now these days are gone, I'm not so self assured (but now these days are gone)
(And now I find) now I find I've changed my mind and opened up the doors
Help me if you can, I'm feeling down
And I do appreciate you being 'round
Help me get my feet back on the ground
Won't you please, please help me, help me, help me, ooh";
        public static string Breakaway = @"Grew up in a small town
And when the rain would fall down
I'd just stare out my window
Dreaming of what could be
And if I'd end up happy
I would pray (I would pray)

Trying hard to reach out
But when I tried to speak out
Felt like no one could hear me
Wanted to belong here
But something felt so wrong here
So I prayed I could break away

I'll spread my wings and I'll learn how to fly
I'll do what it takes 'til I touch the sky
And I'll make a wish
Take a chance
Make a change
And breakaway
Out of the darkness and into the sun
But I won't forget all the ones that I love
I'll take a risk
Take a chance
Make a change
And breakaway

Wanna feel the warm breeze
Sleep under a palm tree
Feel the rush of the ocean
Get on board a fast train
Travel on a jet plane far away
And breakaway

I'll spread my wings and I'll learn how to fly
I'll do what it takes 'til I touch the sky
And I'll make a wish
Take a chance
Make a change
And breakaway
Out of the darkness and into the sun
I won't forget all the ones that I love
I gotta take a risk
Take a chance
Make a change
And breakaway

Buildings with a hundred floors
Swinging round revolving doors
Maybe I don't know where they'll take me
But gotta keep moving on, moving on
Fly away, breakaway

I'll spread my wings
And I'll learn how to fly
Though it's not easy to tell you goodbye
I gotta take a risk
Take a chance
Make a change
And breakaway
Out of the darkness and into the sun
But I won't forget the place I come from
I gotta take a risk
Take a chance
Make a change
And breakaway, breakaway, breakaway";

        public static string Pancakes = @"Can't you see that it's just rainin'
Ain't no need to go outside
But baby
You hardly even notice
When I try to show you this
Song is meant to keep you
Doin' what you're supposed to
Wakin' up too early
Maybe we could sleep in
Make you banana pancakes
Pretend like its the weekend now
We could pretend it all the time
Can't you see that it's just rainin'
There ain't no need to go outside
Just maybe
Halaka ukulele mama made a baby
Really don't mind the practice
Cause you're my little lady
Lady lady love me
Cause I love to lay here lazy
We could close the curtains
Pretend like there's no world outside
We could pretend it all the time
And can't you see that it's just rainin'
There ain't no need to go outside
Ain't no need ain't no need
Can't you see can't you see
Rain all day and I don't mind
But the telephone's singing ringing
It's too early don't pick it up
We don't need to
We got everything we need right here
And everything we need is enough
Just so easy when the whole world fits inside of your arms
Do we really need to pay attention to the alarm
Wake up slow
Mmm wake up slow
But baby
You hardly even notice
When I try to show you this
Song is meant to keep you
From doin' what your supposed to
Wakin' up too early
Maybe we could sleep in
Make you banana pancakes
Pretend like it's the weekend now
We could pretend it all the time
Can't you see that it's just rainin'
There ain't no need to go outside
Ain't no need, ain't no need
Rain all day and I really really really don't mind
Can't you see? Can't you see?
We gotta wake up slow";
        public static string tomorrow = @"And I want to believe you
When you tell me that it'll be okay
Yeah, I try to believe you
But I don't
When you say that it's gonna be
It always turns out to be a different way
I try to believe you
Not today, today, today, today, today
I don't know how I'll feel
Tomorrow, tomorrow (tomorrow, tomorrow)
I don't know what to say
Tomorrow, tomorrow (tomorrow, tomorrow)
Is a different day
(Tomorrow)
It's always been up to you
It's turning around
It's up to me
I'm gonna do what I have to do
Just don't
Give me a little time
Leave me alone a little while
Maybe it's not too late
Not today, today, today, today, today
I don't know how I'll feel
Tomorrow, tomorrow (tomorrow, tomorrow)
I don't know what to say
Tomorrow, tomorrow (tomorrow, tomorrow)
Is a different day
Hey, yeah, yeah, hey, yeah, yeah, and I know I'm not ready
Hey, yeah, yeah, hey, yeah, yeah, maybe tomorrow
Hey, yeah, yeah, hey, yeah, yeah, I'm not ready
Hey, yeah, yeah, hey, yeah, yeah, maybe tomorrow
And I want to believe you
When you tell me that it'll be okay
Yeah I try to believe you
Not today, today, today, today, today
Tomorrow it may change
Tomorrow it may change
Tomorrow it may change
Tomorrow it may change";
        public List<Word> Words;
        public List<ListType> escolhas;
        public WordDatabase(List<ListType> somente)
        {
            escolhas = somente;
            var ListofWords = new List<Word>();

            ////ImWithYouAvrilLavigne
            P_Adiciona_palavra(ListofWords, "I'm", "Eu sou/estou", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Stand", "Ficar de pé - Fique na posicao de pé.", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Standing", "Ficando de pé", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Bridge", "Ponte - Ele atravessou a ponte!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Wait", "Esperar - Espere um minuto!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Waiting", "Esperando - Estou esperando!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Thought", "Pensamento - Eu penso muito sobre isso!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Think", "Pensar - Vou pensar nisso!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "You'd", "Voce seria!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Here", "Aqui - Eu estou aqui!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "There's", "Abreviação de Há, no sentido de Existe um, ou existe algo", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Nothing", "Nada - não tem nada aqui ", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne, ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Footsteps", "Passos - Nossos passos na areia!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Ground", "Chão - Nossos passos no chao!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Listen", "Escutar - Eu escuto!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Listening", "Escutando - Tao me escutando?", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Isn't", "Abrevicao de Não é", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Anyone", "Qualquer um - Pode ser qualquer um!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Try", "Ter - Eu vou tentar!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne, ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Trying", "Tentando - Continue tentando!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne, ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Find", "Procurar - Vamos procurar um lugar pra dormir!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Won't", "Nao irá -  Voce nao irá ir.", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Somebody", "Alguém - Tem alguém esperando por você.", new List<ListType>() {/* ListType.AVRILImWithYouAvrilLavigne,*/ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "It's", "Está -  Está uma noite fria desgracada", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Damn", "Merda -  meeeeerda, fudeo muito!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Night", "Noite - Boa noite!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Nightmare", "Pesadelo - Tive um pesadelo!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Figure out", "Descobrir um jeito - Eu descobri como vou fazer isso dar certo!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Life", "Vida, eu amo minha vida", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Live", "Viver - eu amo viver", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Somewhere", "Algum lugar - vamos para algum lugar?", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Mind", "Mente - Minha mente e muito boa!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "With", "Com - Eu estou com voce!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Search", "Pesquisar - Vamos pesquisar no google!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Searched", "Pesquisado - isso ja foi pesquisado", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Searching", "Pesquisando - estou pesquisando no google!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Anybody", "Qualquer pessoa - Pra mim qualquer pessoa serve!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Right", "Direito - Senta direito menino", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne, ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Mess", "Bagunca - MInha vida esta uma bagunca, uma confusao!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Want", "Querer - Eu quero isso!", new List<ListType>() { ListType.AVRILImWithYouAvrilLavigne });

            ////Naked
            P_Adiciona_palavra(ListofWords, "Wake Up", "Levantar - ta de manha já , Levanta ai!", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Morning", "Manhã - que manhã linda!", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Put", "Colocar - Coloque isso ali!", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Gonna", "Abreviacao de going to!", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Through", "Atravez - ele passou atravez dos metodos errados\nFizemos isso atravez desse metodo", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Another", "Outro - Outra coisa!", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Really", "Realmente - Seriooo?????", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Matter", "Importa - Isso nao importa!", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Feel", "Sentir - eu me sinto bem", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Felt", "Senti - eu me sinti bem aquele dia", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Feeling", "Sentindo - eu estou me sentindo bem", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Inside", "Lado de Dentro - Olhe do lado de dentro desta caixa.", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Around", "Ao redor - Quando voce chega ao meu redor, perto de mim.", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Round", "Volta/Redondo - um objeto redorno, ou volta/turno.", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Wall", "Parede", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Disappeared", "Desapareceu - Gente o menino desapareceu", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Disappear", "desaparecer -  Eu sei como desaparecer", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Appear", "Aparecer - o carro veio a aparecer do nada", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Surround", "Cercar - eu vou cercar voce", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Surrounds", "Seu arredor - Aquilo que esta em volta de voce", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Surrounded", "Cercado - Voce foi cercado pelos inimigos", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Keep", "Manter - Manter vivo o amor que existe em nós", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Fear", "Medo - Eu tenho medo", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Protect", "Proteger - eu vou proteger voce", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Protected", "Protegido - eu estou protegido", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Unprotect", "Desproteger - eu vou desproteger voce", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Unprotected", "Desprotegido - eu estou desprotegido", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "I've", "Abreviacao de Eu tenho", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "You've", "Abreviacao de voce tem/faz", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Trust", "Confiar - eu confio em voce", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Naked", "Pelado - Eu estou pelada!", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Can't", "Nao pode", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Hide", "Esconder - Eu sei como esconder", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Afraid", "Com medo -  ele esta com medo de você", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Cover", "Cobertura - Me de cobertura", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Fall", "Queda - olha que linda essa queda d'agua", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Away", "Distante -  ele ta muito muito distante de nós", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Guess", "Adivinhar -  Adivinha quem e???", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Someone", "Alguém - Alguém deve vir para ajudar a gente", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Had", "Tive -  EU tive", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });
            P_Adiciona_palavra(ListofWords, "Before", "Antes - Antes de voce", new List<ListType>() { ListType.AVRILNakedAvrilLavigne });

            //Anything but Ordinary
            P_Adiciona_palavra(ListofWords, "Sometimes", "Algumas Vezes", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "I", "Eu", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "get", "Pegar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "so", "tão", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "weird", "Estranho", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "even", "ate", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "freak", "Aberração", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "myself", "eu mesmo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "out", "fora", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "laugh", "risada", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "sleep", "dormir", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "It's", "abreviacao de isso é", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "my", "meu", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "lullaby", "musica de ninar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "drive", "dirigir", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "fast", "rapido", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Just", "somente", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "feel", "sentir", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "the", "o", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "danger", "perigo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "want", "quero", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "scream", "grito", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "It", "isso", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "makes", "faz ( para he she it)", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "alive", "vivo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Is", "é", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "it", "isso", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "enough", "suficiente", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "love", "amor", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "breathe", "respire", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "rip", "rasgar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "heart", "coração", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "And", "e", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "leave", "sair;deixar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "here", "aqui", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "bleed", "sangrar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "die", "morrer", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "save", "salvar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "life", "vida", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "I'd", "abreviacao de eu gostaria", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "rather", "em vez", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "be", "ser", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "anything", "qualquer coisa", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "ordinary", "ordinario", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "please", "por favor", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "walk", "andar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "within", "no interior de algo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "lines", "linhas", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Would", "Gostaria", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "make", "fazer", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "boring", "entediante", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "know", "saber", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "that", "que", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Have", "ter", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "been", "sendo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "extreme", "extremo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "knock", "bater", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "off", "desligado", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "feet", "pés", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Come", "venha", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "on", "ligado", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "now", "agora", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "give", "dar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "breath", "respiração", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Let", "deixar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "down", "baixo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "your", "seu", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "defenses", "defesas", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Use", "usar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "no", "não", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "common", "comum", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "sense", "senso", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "If", "Se", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "you", "voce", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "look", "olhar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "will", "irá", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "see", "ver", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "this", "isso", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "world", "mundo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "beautiful", "lindo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Accident", "acidente", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "turbulent", "turbulento", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "succulent", "suculento", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Opulent", "opulento ( pessoa muito rica)", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "permanent", "permanente", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "way", "caminho", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "taste", "gosto;provar", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "Don't", "abreviacao de não faça", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "waste", "desperdicio", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "away", "longe", new List<ListType>() { ListType.AVRILAnythingButOrdinary });
            P_Adiciona_palavra(ListofWords, "self", "auto;proprio;a mesmo", new List<ListType>() { ListType.AVRILAnythingButOrdinary });



            //General
            P_Adiciona_palavra(ListofWords, "Minder", "Cuidador - Eu trabalho como cuidadora!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "My", "Meu - esse é meu chocolate!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Me", "Mim - Me leve com voce!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Get", "Pegar - Pegue isso pra mim!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Wanna", "Abreviacao de Want to!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Eight", "Numero 8", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Breathe", "Respirar/Respire - Respire lentamente", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Breath", "Respiracao - Concentre na sua respiracao", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Sit", "Sente-se -  Sentai!!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Seat", "Assento-  Senta nesse assento ai!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Beach", "Praia-  A gente mora na praia!!", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Bitch", "Cadela - Cachorro femea, ou Vagabunda/puta", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Anywhere", "Qualquer lugar - Qualquer lugar serve pra mim", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Have", "Ter - Eu tenho", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Fit", "Encaixar -  essa roupa serve em mim com certeza", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Lyrics", "Letra de musica", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Body", "Corpo - meu corpo e lindo.", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "See", "Ver - eu consigo enxergar", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Sea", "Mar - eu amo o mar", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Key", "Chave - eu tenho a chave", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Queue", "Fila - Entra na fila", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Bee", "Abelha - Salvem as abelhas", new List<ListType>() { ListType.General });
            P_Adiciona_palavra(ListofWords, "Tea", "Chá - Me da uma xicara de chá", new List<ListType>() { ListType.General });

            //Horas/Numero


            foreach (int item in F_ListaDeNumeros())
            {
                P_Adiciona_palavra(ListofWords, item.ToString(), "Algum Numero", new List<ListType>() { ListType.NumberAndHour });
            }


            P_Adiciona_palavra(ListofWords, "6:00", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, "It's 6 o'clock.");
            P_Adiciona_palavra(ListofWords, "6:05", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's 5 past 6.");
            P_Adiciona_palavra(ListofWords, "6:15", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's quarter past 6.");
            P_Adiciona_palavra(ListofWords, "6:30", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's half past 6.");
            P_Adiciona_palavra(ListofWords, "6:35", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's 25 to 7.");
            P_Adiciona_palavra(ListofWords, "6:45", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's quarter to seven.");
            P_Adiciona_palavra(ListofWords, "6:55", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's 5 to 7.");
            P_Adiciona_palavra(ListofWords, "7:00", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's 7o'clock.");
            P_Adiciona_palavra(ListofWords, "2:00", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's two o'clock");
            P_Adiciona_palavra(ListofWords, "2:05", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's five past two");
            P_Adiciona_palavra(ListofWords, "2:10", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's ten past two");
            P_Adiciona_palavra(ListofWords, "2:15", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's quarter past two");
            P_Adiciona_palavra(ListofWords, "2:20", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's twenty past two");
            P_Adiciona_palavra(ListofWords, "2:25", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's twenty-five past two");
            P_Adiciona_palavra(ListofWords, "2:30", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's half past two");
            P_Adiciona_palavra(ListofWords, "2:35", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's twenty-five to three");
            P_Adiciona_palavra(ListofWords, "2:40", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's twenty to three");
            P_Adiciona_palavra(ListofWords, "2:45", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's quarter to three");
            P_Adiciona_palavra(ListofWords, "2:50", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's ten to three");
            P_Adiciona_palavra(ListofWords, "2:55", "Algum Horário", new List<ListType>() { ListType.NumberAndHour }, " It's five to three");

            ////Letras do alfabeto
            P_Adiciona_palavra(ListofWords, "A", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });
            P_Adiciona_palavra(ListofWords, "E", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });
            P_Adiciona_palavra(ListofWords, "I", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });
            P_Adiciona_palavra(ListofWords, "Q", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });
            P_Adiciona_palavra(ListofWords, "K", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });
            P_Adiciona_palavra(ListofWords, "J", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });
            P_Adiciona_palavra(ListofWords, "U", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });
            P_Adiciona_palavra(ListofWords, "Y", "Alguma letra do alfabeto", new List<ListType>() { ListType.Letter });

            ////

            //Andre
            P_Adiciona_palavra(ListofWords, "Throughout", "Ao longo - Espalhado em todo", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "Although", "Apesar - eu vou la apesar de que eu nao tava afim", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "Though", "apesar - embora ", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "Even Though", "apesar - eu comi a comida apesar dela estar ruim", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "101", "TOpico pra iniciantes, BASICO, - ", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "Aside", "aparte, pro lado, ele empurrou a comida pra longe dele ", new List<ListType>() { ListType.AndreWords });

            P_Adiciona_palavra(ListofWords, "Enough", "suficiente", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "Tough", "Dificil ", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "Through", "Atravez - ele passou atravez dos metodos errados\nFizemos isso atravez desse metodo", new List<ListType>() { ListType.AndreWords });
            P_Adiciona_palavra(ListofWords, "Thought", "Pensamento - Eu penso muito sobre isso!", new List<ListType>() { ListType.AndreWords });


            //Partes do corpo

            //AutoEscola

            //Nomes das COisas de casa       

            //P_Adiciona_palavra(ListofWords, Separador_de_palavras.Separar());

            //Detran
            P_Adiciona_palavra(ListofWords, "irish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "driving", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "theory", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "book", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pdfireland", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "test", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "question", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "and", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "answers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "q", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "what", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "effect", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "does", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "alcohol", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "have", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "on", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "driver", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "behaviour", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mark", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "one", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "answer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "it", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "can", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "increase", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "perception", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "awareness", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slows", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "down", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "a", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "s", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reactions", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "not", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "affect", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reduce", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "confidence", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "in", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "relation", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "to", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cyclists", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "what", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "should", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "be", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "aware", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "of", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "when", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dark", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "winter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mornings", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "evenings", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unlit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "country", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "roads", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "space", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "in", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "the", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "margin", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "road", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "so", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "that", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overtake", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "them", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "without", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reducing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "speed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "or", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "moving", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "out", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "all", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wear", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reflective", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "belts", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "correct", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lighting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "their", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bicycles", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "are", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clearly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "visible", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "much", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "more", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "vulnerable", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "poor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "conditions", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "an", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "oncoming", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cyclist", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "could", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "never", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dazzled", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "by", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "vehicle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lights", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wobble", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "off", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "course", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "into", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "path", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "when", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "turning", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "left", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "side", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "do", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ensure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "following", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "traffic", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "has", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "room", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "if", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "necessary", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "check", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "for", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pedestrians", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "who", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "may", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "come", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "up", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "inside", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "expect", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "coming", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "other", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "will", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stay", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "back", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "allow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "you", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "approach", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "junction", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "with", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "nearside", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wheels", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brushing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "against", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "kerb", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drive", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "along", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cycle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lane", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "accompanied", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "continuous", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "white", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "line", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "taxis", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "motorised", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wheelchairs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "buses", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "motorcyclists", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "incorrectly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "aligned", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "headlights", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "they", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "battery", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "life", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cause", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fire", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dazzle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drivers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bulbs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "prematurely", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "is", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "recommended", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "use", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "coolant", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "summer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "only", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "year", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "round", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "petrol", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "engines", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "maximum", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "permissible", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "car", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "towing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "trailer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "motorway", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "km", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "h", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "national", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "primary", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "which", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "statement", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "true", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "about", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tyre", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pressure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "order", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cope", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sustained", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "high", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "because", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "speeds", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "heat", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "normal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "front", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "during", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "time", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "periods", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tested", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drugs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "at", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "checkpoint", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "during", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "daylight", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hours", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "anytime", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "day", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "night", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "after", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "accident", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "questions", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ireland", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "answersirish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "revision", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pdf", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "considered", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reversing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "parking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "always", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reverse", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "quickly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "get", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "avoid", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "switching", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "your", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rear", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wiper", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "behind", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "using", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "interior", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "view", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mirror", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "vehicles", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "around", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "how", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "make", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "parked", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "safely", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "don", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "t", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "park", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "where", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "endanger", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "users", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "opposite", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "another", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "narrow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "as", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "possible", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "advice", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "give", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "passengers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "before", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "opening", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "doors", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "open", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "door", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "caution", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "proper", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clothing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "protection", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "remove", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "seat", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "belt", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "exit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "immediately", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "leave", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "windows", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slightly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "circulation", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "air", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "checks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "perform", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hazard", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "warning", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clean", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "properly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "secured", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "closed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "according", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pre-crash", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "report", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "how", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "many", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fatal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "collisions", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "was", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "contributory", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "factor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "were", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "killed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "consumption", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pedestrian", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "between", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "less", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "than", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "percentage", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "related", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "collision", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "had", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "consumed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "known", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "age", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "group", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "highest", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "number", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "passenger", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "deaths", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "years", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "practice", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "consequence", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "learner", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drinking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "little", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "just", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "three", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "month", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "disqualification", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "from", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fine", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "six", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "a", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "automatically", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "disqualified", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "long", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "first", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "offence", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "refused", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "provide", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "member", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "garda", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "och", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "na", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sample", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blood", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "urine", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "breath", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "yearsbr", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "people", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "which", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "causing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "period", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "imposed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "court", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "concentration", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bac", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "level", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "excess", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mg", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "two", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "four", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "minimum", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "novice", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "committing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "did", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "person", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "decision", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "seatbelt", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "likely", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "there", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "no", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "driver's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "whether", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "passenger's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "days", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "week", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drink", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "friday", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "saturday", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "thursday", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sunday", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "monday", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "type", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "involved", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "single-vehicle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "multi-vehicle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "majority", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "caused", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tractor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "private", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "motorcycle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "van", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "provisional", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gender", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "females", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "males", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "equally", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "neither", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "nor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "car-trailer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brake", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "indicators", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "plate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "light", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "red", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reflectors", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tail", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "method", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "automatic", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "transmission", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "operate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "accelerator", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "foot", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "right", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "handbrake", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bring", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "halt", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "the", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "generally", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "works", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "right-hand", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wheel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "regularly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "good", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clear", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "windscreen", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wipers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "working", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "correctly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "upholstery", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rev", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "counter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "internal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "load", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "index", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "indicate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "per", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "axle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "carry", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blow-out", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "continue", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "until", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reach", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "garage", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "switch", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "engine", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ignition", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "apply", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "footbrake", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gently", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blade", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fails", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blades", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "replaced", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "soon", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "film", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "oil", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bend", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "arm", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "would", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "know", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brake-light", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bulb", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "standing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "getting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "turn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "notice", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pedal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "become", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "firmer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "under", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "checking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "presses", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "softer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "part", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "must", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "maintained", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "condition", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "radio", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "paintwork", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "free", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "license", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "paperirish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dvla", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "written", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "online", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "power-assisted", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "steering", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pas", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "difficult", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stop", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fluid", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "top", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lower", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gear", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "increased", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "revs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "higher", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reduced", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "is", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "allowed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rebated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "green", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "diesel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fuel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "public", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "used", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "months", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "problem", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "indicated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "suddenly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cease", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "function", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "washer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reservoir", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dry", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fuse", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blown", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "alternator", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "faulty", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "need", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "purpose", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "side-impact", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bars", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "weight", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "thereby", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "improving", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "its", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "grip", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cannot", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overturned", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "protect", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "becoming", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "damaged", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "event", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "crash", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "occupants", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "if", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "frozen", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "roll", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "window", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slowly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "head", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pull", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "defrost", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "replacing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "nuts", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tightened", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tighten", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clockwise", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sequence", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "anti-clockwise", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "diagonally", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "starting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bottom", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "enough", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "partly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "worn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "swap", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "new", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "over-filling", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "damage", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "catalytic", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "converter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pump", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "burst", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "filter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "double-park", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "making", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "delivery", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "double-yellow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "warn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "broken", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clearway", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "let", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "answerstheory", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "complete", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "while", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rain", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "notices", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "system", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "while", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "raining", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wipe", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "newspaper", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "general", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "above", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gross", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brakes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fitted", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "kg", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "legal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tread", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "depth", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tyres", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cars", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "millimetres", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "resting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clutch", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wears", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "allows", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "corners", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "taken", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "facilitates", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "quicker", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "changes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "downhill", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "controlled", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "effectively", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "times", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "area", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "foggy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "short", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "single", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "yellow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "freezing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "weather", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tank", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drop", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "below", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "quarter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "full", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sulphur", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "content", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "treated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "anti-waxing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "agent", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drained", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "becomes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "air-locked", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "loosen", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drain", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "injector", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pipes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bleed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "risk", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "neck", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "injury", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rear-end", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "anti-lock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "adjusted", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "restraint", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spoiler", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "delay", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "operating", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "control", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "enables", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "relax", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "journey", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gives", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "better", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rear-view", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "improves", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ability", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "practise", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "transport", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "exam", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "running", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brake-pedal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fully", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pressed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lightly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "switched", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "add", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "methylated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spirits", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mild", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "anti-freezing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "extra", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "detergent", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hot", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "water", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "why", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "laminated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "glass", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shatters", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "large", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fragments", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "struck", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "object", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "block", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "harmful", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rays", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sun", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "registration", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "etched", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shatter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "kind", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "prohibited", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "this", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sign", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "motor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "homes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "invalid", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "carriages", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mean", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "displayed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "payment", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "euros", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "electronic", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "toll", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "accepted", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "coin", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "basket", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ticket", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dispenser", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "leisure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cashier", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "railway", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "crossing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ahead", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "crossroads", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "equal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "importance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "major", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "holder", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "category", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "w", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "permit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "personal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "insurance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cover", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "assistance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "holds", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "m", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "seating", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "left-hand", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "might", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "outside", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "at", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "take", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "particular", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "care", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "vans", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "trucks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "enter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "code", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pdfirish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "highway", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "skid", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "harsh", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "acceleration", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stopping", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "third", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "too", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "low", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "marking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "keep", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cross", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lines", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wide", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "signalled", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "but", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "distance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tap", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "signal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "section", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shallow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "flooded", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "maintain", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "same", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wet", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "performance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "causes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "run", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "temperature", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "power", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "output", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reduces", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "intend", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "beckon", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "close", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gap", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "entering", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "roundabout", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fast", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "it's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "travelling", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tram", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "why", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tracks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "improve", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "braking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "grid", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "amber", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pass", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unless", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "safe", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "centre", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "u-turn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "business", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "practiceirish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "straddle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hydraulic", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "affected", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stalled", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slow-moving", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "easier", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "heavy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "move", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "faster", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "action", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cuts", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "steer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "engage", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "depress", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "then", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "release", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rear-tyre", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sway", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "towards", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "away", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "front-tyre", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "abs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "deal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "front-wheel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "straight-line", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "push", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "strongly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "press", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rapid", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "intervals", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gets", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rear-wheel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sideways", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "direction", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "heading", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "four-wheel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ease", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "accelerate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "firmly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hold", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "testmock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bursts", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "on", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "busy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "nearest", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "whichever", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sitting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ask", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "allowing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "precaution", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lever", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "neutral", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "valuables", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "secure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sight", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "try", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "speedily", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "approaching", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "angle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "way", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "look", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "noise", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cornering", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "create", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "whine", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "squeal", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "exhaust", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "backfire", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "curb", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "levels", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "emissions", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reconditioned", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "serviced", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "every", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "kilometers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "often", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "manufacturer's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "specification", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "excessive", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pollution", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "additive", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "octane", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rating", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spent", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "vehicle's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "filters", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "changed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pulling", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blocks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wishes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dismount", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "advise", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "irelanddriving", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "jack-knifing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "most", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "occur", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "trying", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sharply", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "springs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "over", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "greased", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "uphill", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "across", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slope", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "jack", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "strong", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lift", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drawing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slides", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "due", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ice", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "roll-over", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overturn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "speeding", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "flat", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drawbar", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "b", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "licence", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "off-road", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unhitching", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "jockey", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "disconnect", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "electrical", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "supply", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "attaching", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "positioned", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pen", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tightly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "well", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "coupling", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "attached", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "securely", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spare", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pin", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "evenly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spread", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "point", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shift", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "taking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overloaded", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "breaking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "going", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "holding", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bends", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "impair", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pdfdriver", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "requested", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "feel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "covered", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slower", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "normally", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "asked", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "held", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "responsible", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "occurs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "refuse", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "available", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "interfere", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "visibility", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "carrying", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "children", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "appropriate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "negotiate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "loaded", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "empty", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "arc", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "flag", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sufficient", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "marker", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overhang", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "exceeds", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "metre", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fragile", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "material", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overhanging", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "changing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "own", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "safety", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "place", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "triangle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "chock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "small", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wooden", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "put", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "danger", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "arise", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "take-off", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shaft", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "disengaged", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "short-circuit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "caught", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rapidly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "immediate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "head-on", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "persons", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "each", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "thrown", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "violently", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "forward", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "backward", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "activate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "being", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "driven", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "very", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "loader", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "breaks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bells", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "phone", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "operator", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "trains", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stopped", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "walk", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "track", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "any", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "are", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unattended", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hill", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "supervised", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "adequate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ventilation", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "downloadirish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stand", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "heads", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "through", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "roof", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wearing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "eye", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "aged", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dangerous", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "seats", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ill", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "backwards", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "applied", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "distract", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "thus", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "attention", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "middle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unguarded", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "restart", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bell", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ringing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "train", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "such", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "constructed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "adapted", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "also", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "designed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "carried", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "kilograms", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "calculate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "permitted", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "refers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unladen", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "adding", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "plus", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "display", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "l-plates", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unaccompanied", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "qualified", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "term", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "weekdays", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "where", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "both", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "encounter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tunnel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "height", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tachograph", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "find", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "containers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cab", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "disengage", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "global", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "positioning", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "irelandtheory", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "congestion", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "suitable", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "amount", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "case", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "associated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "humpbacked", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bridge", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tractor's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "suspension", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "smooth", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bump", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tail-swing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "detached", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shown", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "least", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lamp", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dipped", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "side-lamp", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "generally", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brake-lights", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "uneven", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "surfaces", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spill", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "severe", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bouncing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slippery", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "grass", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "verge", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "loads", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "avoided", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "headlight", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mistake", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "enable", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "see", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reflecting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "exterior", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "temporarily", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "adjust", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reflect", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "remind", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dip", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "his", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mode", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fog", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "replace", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hand", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "questionsmock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "high-intensity", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dusk", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dawn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tail-light", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "falling", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "snow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dense", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "applying", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stall", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "occasionaly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "high-powered", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "actually", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "appear", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "powerful", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "think", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bigger", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gases", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "leaking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "maybe", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "enticed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drowsy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "alert", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "warm", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "somebody", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tempt", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sense", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "alertness", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reassure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "temperatures", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "regular", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stops", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tea", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "coffee", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "drinks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "turned", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shorten", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mirrors", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sound", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "horn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "someone", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "assist", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "download", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "theoryirish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "street", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "occasionally", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "onto", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "carefully", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "specific", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "observations", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "audible", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "device", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blindspots", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "made", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sides", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "including", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blind", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spots", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bystanders", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hair", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shoulder", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shoulders", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sunlight", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "grimy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "enhance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "objects", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "seem", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "closer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "further", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "condensation", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "affecting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "vents", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "few", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cloth", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "demister", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "heating", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "scraper", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cleared", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "boiling", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "salt", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "undertaking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "able", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "heater", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "important", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "maintenance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wide-bodied", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "extended", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "caravan", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "adults", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "situation", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dual", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "carriageway", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "crosswinds", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rider", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "motorcyclist", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "'u'-turn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "p", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "queuing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "multiple", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lanes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "motorcycles", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "either", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "angles", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "position", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "want", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mobile", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wider", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "conversation", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "exempt", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "limits", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "emergency", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "mountain", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rescue", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "doctor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bus", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "breakdown", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "service", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ambulance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brigade", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "identified", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "flashing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blue", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "alternating", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "continuously", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "prepare", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "what's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "happening", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "offer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "prevent", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overtaking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "app", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "quiz", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "meet", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "flash", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "acknowledge", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "seen", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "machinery", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "st", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "proceed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "blocked", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "obstruction", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "next", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "side-road", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "awaiting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wait", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "attempt", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "direct", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "closely", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hard", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "precautions", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unleaded", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "investigate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "fumes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "extinguisher", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "puncture", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "call", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pliable", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "having", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "excessively", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pdfdriving", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "help", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "environment", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "accelerating", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "harshly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sparingly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "contributes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "eco-driving", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "looking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "anticipating", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "maintaining", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "steady", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "selecting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "achieved", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "style", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "share", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "don't", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "longer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "routes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "destination", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "alternatives", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "flow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "constant", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "maximise", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "efficiency", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unnecessary", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "different", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brands", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "read", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "plan", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "under-inflated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "choke", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cold", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "late", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "harm", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "increasing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "carbon", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "monoxide", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gears", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "health", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "risks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "adversely", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "built-up", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "yes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pm", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "am", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sounded", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "under", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "circumstances", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "standard", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "musical", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "momentary", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "leak", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "form", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gas", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "increases", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "improved", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gentle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "desired", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "downloadireland", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "exams", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "climate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "after", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "checked", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "valve", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pad", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clearance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "nut", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tightness", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "vibration", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "alignment", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "balance", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "absorbers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "distribution", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rest", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "floor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "economy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "impaired", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tyre-pressure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "accelerates", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overheat", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tubeless", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "remains", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "remain", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "inflated", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "balanced", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tight", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "absorber", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bounce", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unstable", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "manner", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "trigger", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "airbags", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "weak", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "burn", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "efficiently", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "powered", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "start", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "questionsireland", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "certification", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "study", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "happens", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "acid", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "lubricates", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bearings", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "oil-pressure", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gauge", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "reading", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "comes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "topped", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pace", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "runs", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "tear", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "happen", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "required", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "parts", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "suffer", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "decrease", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shows", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "thick", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "transfers", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "box", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wheel-spin", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "prevents", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "locking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "deploys", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "displays", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "name", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "station", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "playing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "locks", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "skidding", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "certificationirish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "guide", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "operates", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "indicator", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hears", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "clicking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "voltage", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "regulator", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "functioning", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cross-ply", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "radial", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "slowing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "zone", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "been", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "over-filled", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "leaded", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "information", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "revolutions", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "heater-fan", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dial", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gearbox", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "revolution", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wants", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "straight", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "unexpectedly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "brow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "double", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "prepared", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "react", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cut", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "corner", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "dumpsireland", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "intending", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "yield", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "already", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "promptly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "downpour", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "greater", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "distances", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "decreased", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rotate", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "c", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "wheel-spray", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "truck", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "edge", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "roadway", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "range", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "main", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "beam", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "intends", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "passed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "poorly-lit", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "paying", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "end", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "moves", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "current", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "silver", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "girl", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "marked", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ready", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "since", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "footpath", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "conscious", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "example", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "icy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shorter", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "rails", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "island", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "orange", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "swerve", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "ball", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "child", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "collect", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "boy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "children's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bicycle", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "said", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "goodbye", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "friend", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "setting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "moment", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "moved", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "minor", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sharp", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "furthest", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "follow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "shopping", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "sources", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "bright", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "spaces", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "distinguish", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "interview", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "particularly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "careful", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "here", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "one-way", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "overtakes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "markings", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cobblestone", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "gaps", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "stones", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "helps", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "surface", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "even", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "smoothness", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cobblestones", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "varies", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "continuing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "convenient", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "proceeding", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "change", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "terminus", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hidden", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "hedge-cutting", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "pelican", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "calming", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "measures", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "high-sided", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "livestock", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "cameras", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "operation", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "braindump", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });
            P_Adiciona_palavra(ListofWords, "real", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.Detran });

            //Tomorrow

            P_Adiciona_palavra(ListofWords, "and", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "i", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "want", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "to", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "believe", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "you", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "when", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "tell", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "me", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "that", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "it'll", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "be", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "okay", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "yeah", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "try", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "but", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "don't", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "say", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "it's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "gonna", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "it", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "always", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "turns", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "out", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "turn out", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "a", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "different", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "way", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "not", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "today", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "know", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "how", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "i'll", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "feel", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "tomorrow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "what", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "is", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "day", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "been", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "up", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "turning", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "around", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "i'm", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "do", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "have", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "just", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "give", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "little", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "time", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "leave", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "alone", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "while", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "maybe", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "too", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "late", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "hey", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "ready", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "may", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });
            P_Adiciona_palavra(ListofWords, "change", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.AVRILTomorrow });

            //Pankakes
            P_Adiciona_palavra(ListofWords, "can't", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "you", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "see", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "that", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "it's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "just", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "raining", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "ain't", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "no", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "need", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "to", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "go", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "outside", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "but", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "baby", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "hardly", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "even", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "notice", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "when", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "i", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "try", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "show", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "this", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "song", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "is", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "meant", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "keep", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "doing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "what", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "you're", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "supposed", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "waking", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "up", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "too", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "early", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "maybe", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "we", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "could", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "sleep", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "in", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "make", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "banana", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "pancakes", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "pretend", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "like", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "its", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "the", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "weekend", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "now", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "it", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "all", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "time", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "there", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "halaka", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "ukulele", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "mama", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "made", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "a", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "really", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "don't", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "mind", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "practice", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "cause", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "my", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "little", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "lady", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "love", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "me", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "lay", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "here", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "lazy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "close", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "curtains", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "there's", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "world", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "and", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "rain", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "day", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "telephone", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "singing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "ringing", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "pick", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "got", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "everything", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "right", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "enough", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "so", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "easy", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "whole", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "fits", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "inside", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "of", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "your", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "arms", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "do", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "pay", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "attention", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "alarm", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "wake", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "slow", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "from", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });
            P_Adiciona_palavra(ListofWords, "gotta", "Clique em solicitar traducao para ver a traducao", new List<ListType>() { ListType.JackJohnsonBananaPancakes });

            P_Adiciona_palavra(ListofWords, "grew", "cresceu", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "up", "acima", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "in", "no", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "small", "pequeno", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "town", "Cidade", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "when", "quando", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "rain", "chuva", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "would", "seria", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "fall", "cair", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "down", "baixa", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "i'd", "Eu iria", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "just", "somente", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "stare", "olhar fixamente", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "out", "Fora", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "my", "meu", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "window", "janela", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "dreaming", "sonhando", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "of", "do", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "what", "o que", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "could", "poderia", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "be", "estar", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "if", "E se", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "end", "fim", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "happy", "feliz", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "pray", "orar", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "trying", "tentando", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "hard", "Difícil", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "reach", "alcance", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "tried", "tentou", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "speak", "falar", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "felt", "sentido", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "like", "gostar", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "no", "não", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "one", "1", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "hear", "ouvir", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "wanted", "procurado", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "belong", "pertencer", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "here", "aqui", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "something", "alguma coisa", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "so", "tão", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "wrong", "errado", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "prayed", "rezou", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "break", "pausa", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "away", "longe", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "i'll", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "spread", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "wings", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "learn", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "how", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "fly", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "do", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "it", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "takes", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "till", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "touch", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "sky", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "make", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "wish", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "take", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "chance", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "change", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "breakaway", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "darkness", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "into", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "sun", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "won't", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "forget", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "all", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "ones", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "love", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "risk", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "wanna", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "feel", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "warm", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "breeze", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "sleep", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "under", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "palm", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "tree", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "rush", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "ocean", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "get", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "on", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "board", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "fast", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "train", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "travel", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "jet", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "plane", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "far", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "gotta", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "buildings", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "with", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "hundred", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "floors", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "swinging", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "round", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "revolving", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "doors", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "maybe", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "don't", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "where", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "they'll", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "keep", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "moving", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "though", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "easy", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "tell", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "you", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "goodbye", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "place", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "come", "", new List<ListType>() { ListType.Breakaway });
            P_Adiciona_palavra(ListofWords, "from", "", new List<ListType>() { ListType.Breakaway });

            //beatles
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "need", "necessidade", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "somebody", "alguém", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "help", "Socorro", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "not", "não", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "just", "somente", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "anybody", "qualquer pessoa", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "know", "conhecer", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "someone", "alguém", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "never", "Nunca", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "needed", "necessário", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "anybody's", "de qualquer um", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "in", "no", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "any", "qualquer", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "way", "maneira", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "now", "agora", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "these", "estes", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "days", "dias", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "are", "estão", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "gone", "foi", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "i'm", "Eu estou", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "so", "tão", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "self", "auto", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "assured", "Assured", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "find", "encontrar", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "i've", "eu tenho", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "changed", "mudou", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "my", "meu", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "mind", "mente", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "opened", "aberto", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "up", "acima", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "doors", "portas", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "if", "E se", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "can", "pode", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "feeling", "sentindo-me", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "down", "baixa", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "do", "Faz", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "appreciate", "apreciar", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "being", "ser", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "round", "volta", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "get", "obter", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "feet", "pés", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "back", "costas", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "on", "em", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "ground", "terra", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "won't", "não vai", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "please", "por favor", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "life", "vida", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "has", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "oh", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "many", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "ways", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "independence", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "seems", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "to", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "vanish", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "haze", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "every", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "then", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "feel", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "insecure", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "like", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "done", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "before", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "when", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "was", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "younger", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "much", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "than", "", new List<ListType>() { ListType.Beatles_Help });
            P_Adiciona_palavra(ListofWords, "today", "", new List<ListType>() { ListType.Beatles_Help });
            //end beatles

            /*complicated*/

            P_Adiciona_palavra(ListofWords, "life's", "da vida", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "like", "gostar", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "this", "isto", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "that's", "isso é", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "way", "maneira", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "cause", "causa", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "chill", "calafrio", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "out", "Fora", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "what", "o que", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "ya", "sim", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "yelling", "gritando", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "for", "para", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "lay", "deitar", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "back", "costas", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "it's", "Está", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "all", "tudo", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "been", "fui", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "done", "feito", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "before", "antes", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "if", "E se", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "could", "poderia", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "only", "só", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "let", "deixei", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "be", "estar", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "will", "vai", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "see", "Vejo", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "are", "estão", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "when", "quando", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "we're", "nós somos", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "driving", "dirigindo", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "in", "no", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "your", "seu", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "car", "carro", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "you're", "você é", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "talking", "falando", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "one", "1", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "on", "em", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "become", "tornar-se", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "somebody", "alguém", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "else", "outro", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "round", "'volta", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "everyone", "todos", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "watching", "assistindo", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "relax", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "try", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "cool", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "look", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "a", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "fool", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "tell", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "why'd", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "have", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "go", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "make", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "things", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "so", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "complicated", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "acting", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "gets", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "frustrated", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "fall", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "crawl", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "break", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "take", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "get", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "turn", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "into", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "honesty", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "promise", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "i'm", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "never", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "gonna", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "find", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "faking", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "no", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "come", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "over", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "unannounced", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "dressed", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "up", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "something", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "where", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "at", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "making", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "laugh", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "strike", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "pose", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "off", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "preppy", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "clothes", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "know", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "fooling", "", new List<ListType>() { ListType.Avril_Complicated });
            P_Adiciona_palavra(ListofWords, "anyone", "", new List<ListType>() { ListType.Avril_Complicated });
            /**/

            P_Adiciona_palavra(ListofWords, "yeah", "sim", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "can't", "não pode", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "believe", "acreditam", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "news", "notícia", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "today", "hoje", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "oh", "oh", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "close", "perto", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "my", "meu", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "eyes", "olhos", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "make", "faço", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "go", "ir", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "away", "longe", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "how", "como", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "long", "longo", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "must", "devo", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "we", "nós", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "sing", "cantar", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "this", "isto", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "song", "música", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "cause", "causa", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "tonight", "esta noite", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "can", "pode", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "be", "estar", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "as", "Como", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "one", "1", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "broken", "quebrado", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "bottles", "garrafas", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "under", "sob", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "children's", "infantil", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "feet", "pés", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "bodies", "corpos", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "strewn", "espalhado", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "across", "através", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "dead", "morto", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "end", "fim", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "street", "rua", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "won't", "não vai", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "heed", "Guarda", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "battle", "batalha", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "call", "ligar", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "puts", "coloca", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "back", "costas", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "up", "acima", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "against", "contra", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "wall", "parede", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "sunday", "domingo", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "bloody", "sangrento", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "alright", "tudo bem", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "battle's", "batalha", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "just", "somente", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "begun", "começou", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "there's", "há", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "many", "muitos", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "lost", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "tell", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "me", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "who", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "has", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "won", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "trench", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "is", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "dug", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "within", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "our", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "hearts", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "mothers", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "children", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "brothers", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "sisters", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "torn", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "apart", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "let's", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "wipe", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "tears", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "from", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "i'll", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "blood", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "shot", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "true", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "are", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "immune", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "when", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "fact", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "fiction", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "tv", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "reality", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "millions", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "cry", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "eat", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "drink", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "while", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "tomorrow", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "they", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "die", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "real", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "to", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "claim", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "victory", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "jesus", "", new List<ListType>() { ListType.SundayBloodySunday });
            P_Adiciona_palavra(ListofWords, "on", "", new List<ListType>() { ListType.SundayBloodySunday });

            P_Adiciona_palavra(ListofWords, "love", "amar", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "of", "do", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "my", "meu", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "life", "vida", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "you've", "você tem", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "hurt", "doeu", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "broken", "quebrado", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "heart", "coração", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "now", "agora", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "leave", "sair", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "can't", "não pode", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "see", "Vejo", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "bring", "trazer", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "back", "costas", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "don't", "não", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "take", "toma", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "away", "longe", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "from", "a partir de", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "because", "Porque", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "know", "conhecer", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "what", "que", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "means", "significa", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "stolen", "roubado", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "desert", "deserto", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "obrigado", "obrigado", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "will", "vai", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "remember", "lembrar", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "when", "quando", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "this", "isto", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "blown", "estourado", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "over", "sobre", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "everything's", "tudo", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "all", "tudo", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "by", "por", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "way", "caminho", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "grow", "crescer", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "older", "Mais velho", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "be", "estar", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "there", "lá", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "at", "em", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "your", "seu", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "side", "lado", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "remind", "lembrar", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "how", "como", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "still", "ainda", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "oh", "oh", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "hurry", "pressa", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "eh", "Eh", new List<ListType>() { ListType.QueenLoveOfMyLife });
            P_Adiciona_palavra(ListofWords, "alright", "tudo certo(bem)", new List<ListType>() { ListType.QueenLoveOfMyLife });

            P_Adiciona_palavra(ListofWords, "oh", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "yeah", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "don't", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "need", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "permission", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "made", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "my", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "decision", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "to", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "test", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "limits", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "cause", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "business", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "god", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "as", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "witness", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "start", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "what", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "i", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "finished", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "no", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "hold", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "up", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "taking", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "control", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "of", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "this", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "kind", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "moment", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "i'm", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "locked", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "and", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "loaded", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "completely", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "focused", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "mind", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "is", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "open", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "all", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "you", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "got", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "skin", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "stop", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "boy", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "something", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "'bout", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "makes", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "me", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "feel", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "like", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "a", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "dangerous", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "woman", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "wanna", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "do", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "things", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "shouldn't", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "nothing", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "prove", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "bulletproof", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "know", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "doing", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "the", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "way", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "we're", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "moving", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "introducing", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "us", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "new", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "thing", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "savor", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "save", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "it", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "for", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "later", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "taste", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "flavor", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "'cause", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "taker", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "giver", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "only", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "nature", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "live", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "danger", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "girls", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "be", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "bad", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "underneath", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "how", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "feeling", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "inside", "", new List<ListType>() { ListType.ArianaDangerousWoman });
            P_Adiciona_palavra(ListofWords, "there's", "", new List<ListType>() { ListType.ArianaDangerousWoman });

            P_Adiciona_palavra(ListofWords, "how", "como", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "long", "longo", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "will", "vai", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "slide", "deslizar", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "separate", "separado", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "my", "minha", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "side", "lado", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "don't", "não", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "believe", "acreditam", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "it's", "Está", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "bad", "mau", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "slit", "fenda", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "throat", "garganta", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "all", "todos", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "ever", "sempre", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "heard", "ouviu", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "your", "seu", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "voice", "voz", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "through", "através", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "photograph", "fotografia", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "thought", "pensamento", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "up", "acima", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "brought", "trouxe", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "past", "passado", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "once", "uma vez", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "know", "conhecer", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "can", "pode", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "never", "Nunca", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "go", "vai", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "back", "costas", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "gotta", "Tenho que", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "take", "toma", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "on", "em", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "other", "de outros", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "centuries", "séculos", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "are", "estão", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "what", "o que", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "meant", "significou", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "cemetery", "cemitério", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "where", "Onde", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "marry", "casar", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "sea", "mar", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "stranger", "desconhecido", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "things", "coisas", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "could", "poderia", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "change", "mudança", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "mind", "mente", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "pour", "derramar", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "life", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "into", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "paper", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "cup", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "ashtray's", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "full", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "i'm", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "spilling", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "guts", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "she", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "wants", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "am", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "still", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "slut", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "i've", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "got", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "scarlet", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "starlet", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "she's", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "in", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "bed", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "candidate", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "for", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "soul", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "mate", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "bled", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "push", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "trigger", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "pull", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "thread", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "turn", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "hard", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "ride", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "burn", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "out", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "leave", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "yell", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "tell", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "friend", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "tear", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "down", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "then", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "born", "", new List<ListType>() { ListType.OthersideRedHot });
            P_Adiciona_palavra(ListofWords, "again", "", new List<ListType>() { ListType.OthersideRedHot });


            P_Adiciona_palavra(ListofWords, "i", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "met", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "you", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "in", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "the", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "dark", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "lit", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "me", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "up", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "made", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "feel", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "as", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "though", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "was", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "enough", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "we", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "danced", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "night", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "away", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "drank", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "too", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "much", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "held", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "hair", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "back", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "when", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "were", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "throwing", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "then", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "smiled", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "over", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "shoulder", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "for", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "a", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "minute", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "stone-cold", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "sober", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "pulled", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "closer", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "to", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "my", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "chest", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "and", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "asked", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "stay", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "said", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "already", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "told", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "ya", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "think", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "should", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "get", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "some", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "rest", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "knew", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "loved", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "but", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "you'd", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "never", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "know", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "cause", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "played", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "it", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "cool", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "scared", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "of", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "letting", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "go", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "needed", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "showed", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "wanna", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "with", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "until", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "we're", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "grey", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "old", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "just", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "say", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "won't", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "let", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "i'll", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "wake", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "breakfast", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "bed", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "bring", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "coffee", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "kiss", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "on", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "head", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "take", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "kids", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "school", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "wave", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "them", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "goodbye", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "thank", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "lucky", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "stars", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "looked", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "forget", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "i'm", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "older", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "dance", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "right", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "now", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "oh", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "look", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "beautiful", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "ever", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "swear", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "everyday", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "you'll", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "better", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "make", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "this", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "way", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "somehow", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "so", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "love", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "hope", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "darling", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "is", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "more", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "than", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "worth", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "its", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "weight", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "gold", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "we've", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "come", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "far", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "dear", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "how", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "grown", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "live", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "even", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "ghosts", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "always", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "there", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "most", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "gonna", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "'til", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "lungs", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "give", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "out", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "promise", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "death", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "part", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "like", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "our", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "vows", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "wrote", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "song", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "everybody", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "knows", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.SayYouWontLetGoJamesArthur });



            P_Adiciona_palavra(ListofWords, "Dursley", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "cloack", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "clock", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "forget", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "forgot", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "forgotten", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "angry", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "Flood", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "hurry", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "seize", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "seized", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "hurried", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "blame", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "dial", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "worry", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "worried", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "find", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "found", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "building", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "fell", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "fall", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "felt", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "fell", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "catch", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "caught", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "split", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "hug", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "hugged", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "stand", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "stood", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "owl", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "dear", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "Mr", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "Mrs", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "still", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "steal", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "science", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "bear", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "thought", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "think", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "behaviour", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "wonder", "", new List<ListType>() { ListType.HarryPotter1 });
            P_Adiciona_palavra(ListofWords, "spot", "", new List<ListType>() { ListType.HarryPotter1 });

            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "getting", "obtendo", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "better", "Melhor", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "or", "ou", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "do", "Faz", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "feel", "sentir", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "same", "mesmo", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "will", "vai", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "make", "faço", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "easier", "Mais fácil", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "on", "em", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "now", "agora", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "got", "obteve", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "someone", "alguém", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "blame", "culpa", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "say", "dizer", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "one", "1", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "love", "amor", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "life", "vida", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "when", "quando", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "it's", "Está", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "need", "necessidade", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "in", "dentro", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "night", "noite", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "we", "nós", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "get", "pegue", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "share", "compartilhar", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "leaves", "folhas", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "baby", "bebê", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "if", "E se", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "don't", "não", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "care", "Cuidado", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "for", "para", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "did", "fez", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "disappoint", "decepcionar", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "leave", "sair", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "bad", "ruim", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "taste", "gosto", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "your", "seu", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "mouth", "boca", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "act", "Aja", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "like", "gostar", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "never", "Nunca", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "had", "teve", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "want", "quer", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "go", "ir", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "without", "sem", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "well", "bem", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "too", "também", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "late", "tarde", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "tonight", "esta noite", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "drag", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "past", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "out", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "into", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "light", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "we're", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "but", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "carry", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "each", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "other", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "have", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "come", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "here", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "forgiveness", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "raise", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "dead", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "play", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "jesus", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "lepers", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "head", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "ask", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "much", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "more", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "than", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "lot", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "gave", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "nothing", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "all", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "hurt", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "then", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "again", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "temple", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "higher", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "law", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "enter", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "crawl", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "can't", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "be", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "holding", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "what", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "blood", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "should", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "with", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "sisters", "", new List<ListType>() { ListType.OneU2 });
            P_Adiciona_palavra(ListofWords, "brothers", "", new List<ListType>() { ListType.OneU2 });


            P_Adiciona_palavra(ListofWords, "here's", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "to", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "the", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "ones", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "we", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "got", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "cheers", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "wish", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "you", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "were", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "here", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "but", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "you're", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "cause", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "drinks", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "bring", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "back", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "all", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "memories", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "of", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "everything", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "we've", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "been", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "through", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "toast", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "today", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "lost", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "on", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "way", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "and", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "there's", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "a", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "time", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "i", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "remember", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "when", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "did", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "know", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "no", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "pain", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "believed", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "in", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "forever", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "would", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "stay", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "same", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "now", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "my", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "heart", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "feel", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "like", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "december", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "somebody", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "say", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "name", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "can't", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "reach", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "out", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "call", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "will", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "one", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "day", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "yeah", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "everybody", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "hurts", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "sometimes", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "someday", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "gon'", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "be", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "alright", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "go", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "raise", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "glass", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "never", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "felt", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "so", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "hatred", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "was", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "too", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "powerful", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "stop", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "ooh", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "an", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "ember", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "lighting", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "up", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "dark", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "i'll", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "carry", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "these", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "torches", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "for", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "drop", "", new List<ListType>() { ListType.Marron5Memories });
            P_Adiciona_palavra(ListofWords, "oh", "", new List<ListType>() { ListType.Marron5Memories });

            P_Adiciona_palavra(ListofWords, "hey", "Ei", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "what", "o que", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "hell", "inferno", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "do", "Faz", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "want", "quer", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "does", "faz", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "look", "Veja", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "like", "gostar", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "i'm", "Eu estou", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "static", "estático", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "might", "poderia", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "twice", "duas vezes", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "'cause", "'causa", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "moving", "em movimento", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "ok", "Está bem", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "see", "Vejo", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "that", "este", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "can", "posso", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "walk", "andar", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "which", "qual", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "good", "Boa", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "still", "ainda", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "you're", "você é", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "trying", "tentando", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "make", "faço", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "talk", "falar", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "would", "seria", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "your", "seu", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "intention's", "intenções", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "nice", "bom", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "improving", "melhorando", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "for", "para", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "all", "todos", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "know", "conhecer", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "are", "está", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "doing", "fazendo", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "fine", "bem", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "guess", "acho", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "shows", "shows", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "even", "até", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "jewellery", "jóias", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "that's", "isso é", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "fake", "falso", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "shine", "brilho", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "so", "então", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "shut", "fechar", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "mouth", "boca", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "now", "agora", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "big", "grande", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "boy", "Garoto", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "just", "somente", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "myself", "Eu mesmo", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "toy", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "in", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "my", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "nature", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "be", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "changing", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "hard", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "cannot", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "someone", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "who", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "never", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "will", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "say", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "another", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "halting", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "rhyme", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "cliche", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "well", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "right", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "this", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "one", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "time", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "take", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "granted", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "servant", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "subdued", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "doesn't", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "sense", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "here's", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "last", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "bright", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "shift", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "a", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "fool", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "can't", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "judge", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "dog", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "by", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "drool", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "losing", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "smile", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "on", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "face", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "nothing", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "new", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "replace", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "ground", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "peekaboo", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "and", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "won't", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "around", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "cause", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "change", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "with", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "crime", "", new List<ListType>() { ListType.RayMillencolin });
            P_Adiciona_palavra(ListofWords, "derange", "", new List<ListType>() { ListType.RayMillencolin });

            P_Adiciona_palavra(ListofWords, "she", "ela", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "loves", "O amor é", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "yeah", "sim", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "think", "pensar", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "lost", "perdido", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "your", "seu", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "love", "amor", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "well", "bem", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "saw", "Serra", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "her", "dela", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "yesterday", "ontem", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "it's", "Está", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "she's", "ela é", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "thinking", "pensando", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "of", "do", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "told", "contou", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "me", "mim", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "what", "o que", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "say", "dizer", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "says", "diz", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "know", "conhecer", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "that", "este", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "can't", "não pode", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "be", "estar", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "bad", "ruim", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "yes", "sim", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "should", "devemos", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "glad", "feliz", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "said", "disse", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "hurt", "doeu", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "so", "então", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "almost", "quase", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "mind", "mente", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "now", "agora", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "knows", "conhece", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "you're", "você é", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "not", "não", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "hurting", "machucando", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "kind", "tipo", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "ooh", "ooh", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "with", "com", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "like", "gostar", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "up", "acima", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "only", "só", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "fair", "justo", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "pride", "orgulho", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "can", "posso", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "too", "também", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "apologize", "peça desculpas", new List<ListType>() { ListType.SheLovesYouTheBeatles });
            P_Adiciona_palavra(ListofWords, "because", "Porque", new List<ListType>() { ListType.SheLovesYouTheBeatles });

            P_Adiciona_palavra(ListofWords, "i", "Eu", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "could", "poderia", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "stay", "fique", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "awake", "acordado", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "just", "somente", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "hear", "ouvir", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "you", "você", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "breathing", "respiração", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "watch", "ver", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "smile", "sorrir", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "while", "enquanto", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "are", "está", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "sleeping", "dormindo", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "you're", "você é", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "far", "longe", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "away", "longe", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "dreaming", "sonhando", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "spend", "gastar", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "my", "meu", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "life", "vida", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "in", "dentro", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "this", "isto", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "sweet", "doce", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "surrender", "entrega", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "lost", "perdido", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "moment", "momento", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "forever", "para sempre", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "every", "cada", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "spent", "gasto", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "with", "com", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "treasure", "Tesouro", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "don't", "não", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "want", "quer", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "close", "perto", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "eyes", "olhos", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "fall", "outono", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "asleep", "adormecido", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "cause", "causa", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "i'd", "Eu iria", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "miss", "senhorita", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "baby", "bebê", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "thing", "coisa", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "even", "até", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "when", "quando", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "dream", "Sonhe", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "of", "do", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "sweetest", "mais doce", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "will", "vai", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "never", "Nunca", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "do", "Faz", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "still", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "lying", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "feeling", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "heart", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "beating", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "i'm", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "wondering", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "what", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "if", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "me", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "seeing", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "then", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "kiss", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "thank", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "god", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "we're", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "together", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "ever", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "one", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "be", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "right", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "here", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "like", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "hold", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "feel", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "so", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "mine", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "for", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "all", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "rest", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "time", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });
            P_Adiciona_palavra(ListofWords, "yeah", "", new List<ListType>() { ListType.Aerosmith_IDontWantToMissAThing });

            P_Adiciona_palavra(ListofWords, "share", "compartilhar", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "my", "minha", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "life", "vida", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "take", "levar", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "me", "Eu", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "for", "para", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "what", "o que", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "i", "eu", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "am", "sou", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "cause", "causa", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "i'll", "doente", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "never", "Nunca", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "change", "mudança", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "all", "tudo", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "colors", "cores", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "love", "amor", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "ask", "perguntar", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "too", "também", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "much", "Muito de", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "just", "somente", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "that", "naquela", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "are", "estão", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "everything", "tudo", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "do", "Faz", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "don't", "não", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "really", "realmente", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "need", "necessidade", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "look", "Veja", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "very", "muito", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "further", "avançar", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "want", "quer", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "have", "ter", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "go", "vai", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "where", "Onde", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "follow", "Segue", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "will", "vontade", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "hold", "segure", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "back", "voltar", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "again", "novamente", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "this", "esta", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "passion", "paixão", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "inside", "lado de dentro", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "can't", "não pode", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "run", "corre", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "from", "a partir de", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "myself", "Eu mesmo", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "there's", "há", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "nowhere", "lugar algum", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "hide", "ocultar", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "make", "faço", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "close", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "one", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "more", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "door", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "hurt", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "anymore", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "stay", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "in", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "arms", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "if", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "dare", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "or", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "must", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "imagine", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "there", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "walk", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "away", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "nothing", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "see", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "through", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "right", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "the", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "heart", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "of", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "break", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "down", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "walls", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "with", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "strength", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "hm", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "knew", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "like", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "i've", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "known", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "a", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "memory", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "survive", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "can", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "on", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "remember", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "forever", "", new List<ListType>() { ListType.WhitneyIHaveNothing });
            P_Adiciona_palavra(ListofWords, "no", "", new List<ListType>() { ListType.WhitneyIHaveNothing });

            P_Adiciona_palavra(ListofWords, "i'm", "Eu estou", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "not", "não", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "perfect", "perfeito", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "person", "pessoa", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "there's", "há", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "many", "vários", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "things", "coisas", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "i", "eu", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "wish", "desejo", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "didn't", "não", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "do", "Faz", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "continue", "Prosseguir", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "learning", "Aprendendo", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "never", "Nunca", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "meant", "significou", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "those", "Essa", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "so", "tão", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "have", "ter", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "say", "dizer", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "before", "antes", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "go", "vai", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "that", "naquela", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "just", "somente", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "want", "quer", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "know", "conhecer", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "i've", "eu tenho", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "found", "encontrado", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "reason", "razão", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "for", "para", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "me", "Eu", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "change", "mudança", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "who", "quem", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "used", "usava", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "be", "ser", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "start", "começar", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "over", "sobre", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "new", "novo", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "sorry", "Desculpe", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "hurt", "machucar", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "it's", "Está", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "something", "alguma coisa", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "must", "devo", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "live", "viver", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "with", "com", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "everyday", "todo dia", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "all", "tudo", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "pain", "dor", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "put", "colocar", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "through", "Através dos", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "could", "poderia", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "take", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "it", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "away", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "one", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "catches", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "tears", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "that's", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "why", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "need", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "hear", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "show", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "side", "", new List<ListType>() { ListType.TheReasonHoobastank });
            P_Adiciona_palavra(ListofWords, "of", "", new List<ListType>() { ListType.TheReasonHoobastank });

            P_Adiciona_palavra(ListofWords, "i", "eu", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "was", "estava", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "down", "baixa", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "at", "no", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "the", "a", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "new", "novo", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "amsterdam", "amsterdam", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "staring", "encarando", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "this", "esta", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "yellow-haired", "de cabelo amarelo", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "girl", "menina", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "mr", "Sr", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "jones", "Jones", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "strikes", "greves", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "up", "pra cima", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "conversation", "conversação", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "with", "com", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "black-haired", "cabelos negros", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "flamenco", "flamenco", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "dancer", "dançarino", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "you", "vocês", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "know", "conhecer", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "she", "ela", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "dances", "danças", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "while", "enquanto", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "his", "seu", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "father", "pai", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "plays", "tocam", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "guitar", "guitarra", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "she's", "ela é", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "suddenly", "De repente", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "beautiful", "bela", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "and", "e", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "we", "nós", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "all", "tudo", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "want", "quer", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "something", "alguma coisa", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "man", "homem", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "wish", "desejo", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "so", "tão", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "come", "venha", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "dance", "dança", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "silence", "silêncio", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "through", "Através dos", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "morning", "manhã", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "yeah", "sim", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "uh", "Uh", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "huh", "Hã", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "cut", "cortar", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "maria", "maria", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "show", "mostrar", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "me", "Eu", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "some", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "of", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "them", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "spanish", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "pass", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "bottle", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "believe", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "in", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "help", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "anything", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "cause", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "wanna", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "be", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "someone", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "who", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "believes", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "tell", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "each", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "other", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "fairy", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "tales", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "stare", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "women", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "looking", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "ah", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "no", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "smiling", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "bright", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "lights", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "coming", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "stereo", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "when", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "everybody", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "loves", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "can", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "never", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "lonely", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "well", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "i'm", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "gon'", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "paint", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "my", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "picture", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "myself", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "blue", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "red", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "black", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "gray", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "colors", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "are", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "very", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "meaningful", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "is", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "favorite", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "color", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "felt", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "symbolic", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "yesterday", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "if", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "knew", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "picasso", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "would", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "buy", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "play", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "looked", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "into", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "future", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "don't", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "think", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "standing", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "spotlight", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "bought", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "will", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "said", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "gonna", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "lion", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "as", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "cats", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "big", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "stars", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "but", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "got", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "different", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "reasons", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "for", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "to", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "stumbling", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "barrio", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "perfect", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "there's", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "somebody", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "bob", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "dylan", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "wishes", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "he", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "just", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "little", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "more", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "funky", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "son", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "that's", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "about", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "video", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "look", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "television", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "see", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "right", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "back", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "why", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "how", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "happy", "", new List<ListType>() { ListType.MrJones });
            P_Adiciona_palavra(ListofWords, "we're", "", new List<ListType>() { ListType.MrJones });

            P_Adiciona_palavra(ListofWords, "that's", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "great", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "it", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "starts", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "with", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "an", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "earthquake", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "birds", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "and", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "snakes", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "aeroplanes", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "lenny", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "bruce", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "is", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "afraid", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "eye", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "of", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "a", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "hurricane", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "listen", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "to", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "yourself", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "churn", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "world", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "serves", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "its", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "own", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "needs", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "don't", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "mis-serve", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "speed", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "up", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "notch", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "grunt", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "no", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "strength", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "the", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "ladder", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "clatter", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "fear", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "height", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "down", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "wire", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "in", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "fire", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "represent", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "seven", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "games", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "government", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "for", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "hire", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "combat", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "site", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "left", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "her", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "wasn't", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "coming", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "hurry", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "furies", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "breathing", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "neck", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "team", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "by", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "reporters", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "baffled", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "trumped", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "tethered", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "cropped", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "look", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "at", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "that", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "low", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "plane", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "fine", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "then", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "uh", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "oh", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "overflow", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "population", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "common", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "group", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "but", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "it'll", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "do", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "save", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "serve", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "heart", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "bleed", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "tell", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "me", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "rapture", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "reverent", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "right", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "you", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "vitriolic", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "patriotic", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "slam", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "fight", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "bright", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "light", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "feeling", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "pretty", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "psyched", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "end", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "as", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "we", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "know", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "i", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "feel", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "six", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "o'clock", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "t", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "v", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "hour", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "get", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "caught", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "foreign", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "tower", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "slash", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "burn", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "return", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "lock", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "him", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "uniform", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "book", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "burning", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "bloodletting", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "every", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "motive", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "escalate", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "automotive", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "incinerate", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "candle", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "step", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "watch", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "heel", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "crush", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "this", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "means", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "cavalier", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "renegade", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "steering", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "clear", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "tournament", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "lies", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "offer", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "solutions", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "alternatives", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "decline", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "had", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "some", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "time", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "alone", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "other", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "night", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "drifted", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "nice", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "continental", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "drift", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "divide", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "mountains", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "sit", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "line", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "leonard", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "bernstein", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "leonid", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "brezhnev", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "lester", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "bangs", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "birthday", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "party", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "cheesecake", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "jellybean", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "boom", "", new List<ListType>() { ListType.EndOfWorld });
            P_Adiciona_palavra(ListofWords, "symbiotic", "", new List<ListType>() { ListType.EndOfWorld });

            P_Adiciona_palavra(ListofWords, "i", "eu", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "can", "posso", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "almost", "quase", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "see", "Vejo", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "it", "isto", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "that", "naquela", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "dream", "Sonhe", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "i'm", "Eu estou", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "dreaming", "sonhando", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "but", "mas", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "there's", "há", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "a", "uma", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "voice", "voz", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "inside", "lado de dentro", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "my", "minha", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "head", "cabeça", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "saying", "dizendo", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "you'll", "você vai", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "never", "Nunca", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "reach", "alcançar", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "every", "cada", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "step", "Passo", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "taking", "tirando", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "move", "mover", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "make", "faço", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "feels", "sentimentos", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "lost", "perdido", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "with", "com", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "no", "não", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "direction", "direção", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "faith", "fé", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "is", "é", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "shaking", "tremendo", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "gotta", "Tenho que", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "keep", "guarda", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "trying", "tentando", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "held", "guardado", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "high", "Alto", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "always", "sempre", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "gonna", "vai", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "be", "ser", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "another", "outro", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "mountain", "montanha", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "wanna", "quer", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "an", "a", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "uphill", "morro acima", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "battle", "batalha", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "sometimes", "as vezes", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "have", "ter", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "to", "para", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "lose", "perder", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "aingt", "aingt", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "about", "cerca de", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "how", "Como as", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "fast", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "get", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "there", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "what's", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "waiting", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "on", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "the", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "other", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "side", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "it's", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "climb", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "struggles", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "facing", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "I Love you natalia", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "chances", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "might", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "knock", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "me", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "down", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "not", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "breaking", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "may", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "know", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "these", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "are", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "moments", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "remember", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "most", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "yeah", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "just", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "going", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "and", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "strong", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "pushing", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "'cause", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "you're", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "moving", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "climbing", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "baby", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "all", "", new List<ListType>() { ListType.TheClimb });
            P_Adiciona_palavra(ListofWords, "your", "", new List<ListType>() { ListType.TheClimb });


            /*
             * 0-- n conheco nenhum
             * 1-- conheco 1
             * 2 conheco os 2
            */
            P_ADICIONA_HOMOFONES(ListofWords, 
@"blip bleep 0
britches breeches 0
crick creek 0
din dean 0
finned fiend 0
flit fleet 0
gip jeep 0
grist greased 0
pit peat 0
sim seam 0
sip seep 0
shin sheen 0
skit skeet 0
slick sleek 0
slit sleet 0
tick teak 0
tit teat 0
tizz tease 0
bid bead 2
bitch beech 1
biz bees 1
chick cheek 2
chit cheat 1
dip deep 1
fist feast 1
fizz fees 0
hip heap 1
kid keyed 2
pill peel 1
pip peep 0
piss peace 2
sill seal 1
sim seem 1
skid skied 0
skim scheme 1
till teal 1
tizz teas 1
bit beat 2
bitch beach 2
itch each 2
gin gene 0
grid greed 2
hid heed 0
hill he'll 2
ill eel 1
kip keep 1
knit neat 0
lick leak 2
lip leap 2
mill meal 1
pick peek 2
piss piece 2
pitch peach 0
risen reason 2
shit sheet 2
sick seek 2
sin scene 2
sin seen 2
still steel 2
tin teen 2
did deed 2
fill feel 2
fit feet 2
grin green 1
hit heat 2
is ease 2
mitt meet 1
slip sleep 2
still steal 2
bin bean 2
chip cheap 2
his he's 2
it eat 2
sit seat 2");

            Words = ListofWords.Randomize().ToList();
            //Words = ListofWords.ToList();
        }

        private void P_ADICIONA_HOMOFONES(List<Word> listofWords, string v)
        {
            foreach (var item in v.Split( Environment.NewLine.ToCharArray()).Where(x => x.Trim() != ""))
            {
                var words = item.Split(' ');
                var type = words[2];

                ListType newone = ListType.MinimalPairs_i_ee_EASY;

                if (type == "1")
                {
                    newone = ListType.MinimalPairs_i_ee_MEDIUM;
                }

                if (type == "0")
                {
                    newone = ListType.MinimalPairs_i_ee_HARD;
                }

                P_Adiciona_palavra(listofWords, words[0], "Clique em solicitar traducao para ver a traducao", new List<ListType>() { newone });
                P_Adiciona_palavra(listofWords, words[1], "Clique em solicitar traducao para ver a traducao", new List<ListType>() { newone });
            }
        }

        internal static List<string> GetMusic(Prova provaEscolhida)
        {
            var naked = @"
I wake up in the morning
Put on my face
The one that's gonna get me
Through another day
Doesn't really matter
How I feel inside
'Cause life is like a game sometimes
But then you came around me
The walls just disappeared
Nothing to surround me
And keep me from my fears
I'm unprotected
See how I've opened up
Oh, you've made me trust
Because I've never felt like this before

I'm naked
Around you
Does it show?
You see right through me
And I can't hide

I'm naked
Around you
And it feels so right
I'm trying to remember
Why I was afraid
To be myself and let the
Covers fall away
I guess I never had someone like you
To help me, to help me fit
In my skin
I never felt like this before

I'm naked
Around you
And it feels so right
I'm naked
Oh oh yeah
Does it show?
Yeah, I'm naked
Oh oh, yeah, yeah, yeah, yeah
Oh oh
I'm naked around you
Does it show?
I'm so naked around you
And I can't hide
You're gonna, you're gonna see right through
I'm so naked around you
And I can't hide
You're gonna see right through
";
            string anything = @"
Sometimes I get so weird
I even freak myself out
I laugh myself to sleep
It's my lullaby
Sometimes I drive so fast
Just to feel the danger
I want to scream
It makes me feel alive
Is it enough to love?
Is it enough to breathe?
Somebody rip my heart out
And leave me here to bleed

Is it enough to die?
Somebody save my life
I'd rather be anything but ordinary please
To walk within the lines
Would make my life so boring
I want to know that I
Have been to the extreme
So knock me off my feet
Come on now give it to me
Anything to make me feel alive
Is it enough to love?
Is it enough to breath?
Somebody rip my heart out
And leave me here to bleed

Is it enough to die?
Somebody save my life
I'd rather be anything but ordinary please
Let down your defenses
Use no common sense
If you look you will see
That this world is a beautiful
Accident turbulent succulent
Opulent permanent, no way
I want to taste it
Don't want to waste it away
Sometimes I get so weird
I even freak myself out
I laugh my self to sleep
It's my lullaby
Is it enough?
Is it enough to breath?
Somebody rip my heart out
And leave me here to bleed
Is it enough to die?
Somebody save my life
I'd rather be anything but ordinary please
Is it enough?
Is it enough to die?
Somebody save my life
I'd rather be anything but ordinary please
";


            string imwithyou = @"
I'm standing on a bridge
I'm waitin' in the dark
I thought that you'd be here by now
There's nothing but the rain
No footsteps on the ground
I'm listening but there's no sound
Isn't anyone tryin' to find me?
Won't somebody come take me home?
It's a damn cold night
Trying to figure out this life
Won't you take me by the hand?
Take me somewhere new
I don't know who you are
But I, I'm with you
I'm with you
I'm looking for a place
I'm searching for a face
Is anybody here I know
'Cause nothing's going right
And everything's a mess
And no one likes to be alone
Isn't anyone tryin' to find me?
Won't somebody come take me home?
It's a damn cold night
Trying to figure out this life
Won't you take me by the hand?
Take me somewhere new
I don't know who you are
But I, I'm with you
I'm with you
Oh, why is everything so confusing?
Maybe I'm just out of my mind";

            

            string escolhida = "";

            if (provaEscolhida == Prova.Naked)
            {
                escolhida = naked;
            }

            if (provaEscolhida == Prova.AnythingButOrdinary)
            {
                escolhida = anything;
            }

            if (provaEscolhida == Prova.ImWithYouAvrilLavigne)
            {
                escolhida = imwithyou;
            }

            if (provaEscolhida == Prova.Nenhuma)
            {
                escolhida = "ABRA O PROGRAMA DE NOVO E SELECIONE UMA PROVA";
            }

            if (provaEscolhida == Prova.Tomorrow)
            {
                escolhida = tomorrow;
            }

            List<string> a = Regex.Split(escolhida, "\r\n|\r|\n").ToList();
            return a.Where(x => x.Trim() != "").ToList();


        }

        private void P_Adiciona_palavra(List<Word> listofWords, List<Word> lists)
        {
            foreach (var item in lists)
            {
                P_Adiciona_palavra(listofWords, item);
            }
        }

        private void P_Adiciona_palavra(List<Word> listofWords, Word item)
        {
            P_Adiciona_palavra(listofWords,item.TheWord,item.Description,item.WordType,item.WhatToSay);
        }

        private IEnumerable<int> F_ListaDeNumeros()
        {
            Random rand = new Random();
            var ints = Enumerable.Range(0, 100)
                                         .Select(i => new Tuple<int, int>(rand.Next(100), i))
                                         .OrderBy(i => i.Item1)
                                         .Select(i => i.Item2).Take(6);

            Random rand2 = new Random();
            var ints2 = Enumerable.Range(100, 1000)
                                         .Select(i => new Tuple<int, int>(rand2.Next(1000), i))
                                         .OrderBy(i => i.Item1)
                                         .Select(i => i.Item2).Take(6);


            Random rand3 = new Random();
            var ints3 = Enumerable.Range(1000, 10000)
                                         .Select(i => new Tuple<int, int>(rand3.Next(10000), i))
                                         .OrderBy(i => i.Item1)
                                         .Select(i => i.Item2).Take(6);


            var ints4 = new List<int>() { 1,1111,15,55,50,65,80,90,70,60};

            return (ints.Concat(ints2).Concat(ints3).Concat(ints4)).Distinct();
        }

        private void P_Adiciona_palavra(List<Word> listofWords, string word, string description, List<ListType> lists = null,string OQueFalar = "")
        {
            if (word.Trim() == "") return;


            if (lists.Where(x => escolhas.Contains(x)).Any())
            {

                if (listofWords.Where(x => x.TheWord.ToLower().Contains(word.ToLower())).Any())
                {
                    // add the types that are not comulative
                }
                else
                {
                    listofWords.Add(new Word() { TheWord = word.Trim(), Description = description, WordType = lists, WhatToSay = OQueFalar });
                }
                
            }            
        }

  
    }

    public class Word
    {

        public string TheWord { get; set; }
        public string Description { get; set; }
        public bool Mandatory { get;  set; }
        public bool VerDescricao { get; internal set; }
        public int Ouvir { get; internal set; }
        public bool Pulou { get; internal set; }
        public List<string> TentouDigitar { get;  set; }

        public List<ListType> WordType { get; internal set; }
        public string WhatToSay { get; internal set; }
    }

}